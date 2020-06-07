﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using onlinelearningbackend.DAL;
using onlinelearningbackend.Models;

namespace onlinelearningbackend.Controllers
{
    [Authorize]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseManager _CourseManager;
        public CourseController(ICourseManager CM)
        {
            _CourseManager = CM;

        }
        // GET: api/Course
        [HttpGet("{CourseId}")]
        [Route("api/Course/ByCourseId/{CourseId}")]
        public IActionResult GetByCourseId(int CourseId)
        {

            string UserId = User.Claims.First(c => c.Type == "UserId").Value;
            var c= _CourseManager.CoursesByCourseId(CourseId);
            return Ok(new { c });
        }
        // GET: api/Course
        [HttpGet("{StudentId}")]
        [Route("api/Course/ByStudentId/{StudentId}")]
        public IActionResult GetByStudentId(string StudentId)
        {

            string UserId = User.Claims.First(c => c.Type == "UserId").Value;
            var c=_CourseManager.CoursesByStudentId(StudentId);
            return Ok(new { c });
        }
        // GET: api/Course
        [HttpGet("{InstructorId}")]
        [Route("api/Course/ByInstructorId/{InstructorId}")]
        public IActionResult  GetByInstructorId(string InstructorId)
        {

            string UserId = User.Claims.First(c => c.Type == "UserId").Value;
            var c=_CourseManager.CoursesByInstructorId(InstructorId);
            return Ok(new { c });
        }
        // GET: api/Course
        [HttpGet("{TrackId}")]
        [Route("api/Course/ByTrackId/{TrackId}")]
        public IActionResult GetByTrackId(int TrackId)
        {

                var c=_CourseManager.CoursesByTrackId(TrackId);
            return Ok(new { c });
        }

      

        [Route("api/Course/Add")]
        // POST: api/Course
        [HttpPost]
        public IActionResult PostAddCourse([FromBody] Course NewCourse)
        {
            if(ModelState.IsValid==false)
                return BadRequest(new { message = "invalid Course info" }) ;
            string UserId = User.Claims.First(c => c.Type == "UserId").Value;
           var c= _CourseManager.AddCourse(NewCourse, UserId);
            return Ok(new {c });
        }

        
        [Route("api/Course/Edit/{CourseId}")]
        // PUT: api/Course/5
        [HttpPut("{CourseId}")]
        public IActionResult PutEditCourse( [FromBody] Course EditedCourse)
        {
            var c= _CourseManager.EditCourse(EditedCourse);
            return Ok(new { c });
        }


        [Route("api/Course/Delete/{CourseId}")]
        // PUT: api/Course/5
        [HttpDelete("{CourseId}")]
        public IActionResult DeleteCourse(int CourseId)
        {
             _CourseManager.DeleteCoursesByCourseId(CourseId);
            return Ok();
        }
        

        [Route("api/Course/Enroll/{CourseId}")]
        // PUT: api/Course/5
        [HttpPost("{CourseId}")]
        public IActionResult PostEnrollStudent(int CourseId)
        {
            string UserId = User.Claims.First(c => c.Type == "UserId").Value;

            _CourseManager.EnrollStudentInCourse(CourseId,UserId);
            return Ok();
        }
    }
}