﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onlinelearningbackend.Models
{
    public class ProjectModel
    {
        public int ProjectModelId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public virtual ICollection<UserProjectModel> UserProjectModels { get; set; } = new HashSet<UserProjectModel>();
        public virtual ICollection<ProjectMaterialModel> ProjectMaterialModels { get; set; } = new HashSet<ProjectMaterialModel>();

    }
}
