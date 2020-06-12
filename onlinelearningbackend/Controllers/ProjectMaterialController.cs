﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using onlinelearningbackend.DAL;
using onlinelearningbackend.Helpers;
using onlinelearningbackend.Models;
using onlinelearningbackend.Repo.IManager;

namespace onlinelearningbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectMaterialController : ControllerBase
    {
        private IWebHostEnvironment hostingEnvironment;

        IProjectMaterialManager ProjectMaterialManager;
        public ProjectMaterialController(IProjectMaterialManager _CMM, IWebHostEnvironment hostingEnvironment)
        {
            ProjectMaterialManager = _CMM;
            this.hostingEnvironment = hostingEnvironment;

        }

        [HttpPost]
        [Route("api/Project/ProjectMaterial/{ProjectId}")]
        //////////////////////may cause error 
        public async Task<IActionResult> AddProjectMaterial(int ProjectId, [FromForm] List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            var uploader = new Uploader(hostingEnvironment);
            var AllMaterial = new List<ProjectMaterialModel>();
            if (files.Count() == 0 || ProjectId <= 0)
                return BadRequest();
            foreach (IFormFile source in files)
            {
                if (source.Length == 0)
                    continue;
                //get uploaded file name as in the user pc
                string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.ToString().Trim('"');

                filename = uploader.EnsureCorrectFilename(filename);
                var PathToBeSavedInDB = uploader.GetPathAndFilename(filename);
                using (FileStream output = System.IO.File.Create(PathToBeSavedInDB))
                    await source.CopyToAsync(output);
                var cm = ProjectMaterialManager.AddMaterial(ProjectId, PathToBeSavedInDB).FirstOrDefault();
                AllMaterial.Add(cm);
            }
            return Ok(AllMaterial);
        }


        [HttpGet]
        [Route("api/Project/DownloadProjectMaterial/{FileName}")]

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt","text/plain" },
                {".pdf","application/pdf" },
                {".jpg","image/jpeg" },
                {".jpeg","image/jpeg" },
                {".png","image/png" },
            };
        }
        public async Task<IActionResult> DownloadProjectMaterial(string FileName)
        {

            var _Path = this.hostingEnvironment.WebRootPath + @"\uploads\" + FileName;
            var memory = new MemoryStream();
            using (var stream = new FileStream(_Path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(_Path).ToLowerInvariant();
            return File(memory, GetMimeTypes()[ext], Path.GetFileName(_Path));
        }


        [HttpGet]
        [Route("api/Project/DeleteProjectMaterial/{FileName}")]

        ///needs to be reviewed

        public IActionResult DeleteProjectMaterial(string FileName)
        {

            var _Path = this.hostingEnvironment.WebRootPath + @"\uploads\" + FileName;

            if (_Path == null)
            {
                return NotFound();
            }
            else
            {

                System.IO.File.Delete(_Path);

                ProjectMaterialManager.DeleteMaterialByPath(_Path);
                return Ok("file deleted");
            }



        }


    }
}