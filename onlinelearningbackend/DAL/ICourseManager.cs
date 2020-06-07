﻿using onlinelearningbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlinelearningbackend.DAL
{
   public interface ICourseManager
    {
        Course CoursesByCourseId(int CourseId);
        IEnumerable<Course> CoursesByStudentId(string StudentId);
        IEnumerable<Course> CoursesByInstructorId(string InstructorId);
        IEnumerable<Course> CoursesByTrackId(int TrackId);
        Course AddCourse(Course NewCourse, string InstructorId);
        Course EditCourse(Course EditedCourse);
        void DeleteCoursesByCourseId(int CourseId);
        void EnrollStudentInCourse(int CourseId, string StudentId);








    }
}