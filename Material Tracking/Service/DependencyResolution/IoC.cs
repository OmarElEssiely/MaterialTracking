// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using StructureMap;
using StructureMap.Graph;
using System;
using System.Threading;

namespace Service.DependencyResolution {

    public static class ObjectFactory
    {
        private static readonly Lazy<Container> _containerBuilder =
            new Lazy<Container>(defaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return _containerBuilder.Value; }
        }

        private static Container defaultContainer()
        {
            return new Container(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.AssembliesFromApplicationBaseDirectory(
                        filter => filter.FullName.StartsWith("MT"));
                    scan.WithDefaultConventions();
                });
            });
        }
    }




    //public static class IoC {
    //    public static IContainer Initialize() {
    //        ObjectFactory.Initialize(x =>
    //                    {
    //                        x.Scan(scan =>
    //                                {
    //                                    scan.TheCallingAssembly();
    //                                    scan.AssembliesFromApplicationBaseDirectory(
    //                                        filter => filter.FullName.StartsWith("MT"));
    //                                    scan.WithDefaultConventions();
    //                                });
    //        //                x.For<IExample>().Use<Example>();
    //                    });
    //        return ObjectFactory.Container;
    //    }
    //}
}