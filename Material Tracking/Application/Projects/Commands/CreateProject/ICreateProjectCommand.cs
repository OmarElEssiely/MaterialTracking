﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects.Commands.CreateProject
{
    public interface ICreateProjectCommand
    {
        void Execute(CreateProjectModel model);

    }
}
