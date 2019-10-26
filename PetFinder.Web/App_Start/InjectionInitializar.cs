using PetFinder.Data.Context;
using PetFinder.Data.Interfaces;
using PetFinder.Data.Repository;
using PetFinderDomain.Interfaces.Repository;
using PetFinderDomain.Interfaces.Service;
using PetFinderDomain.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFinder.Web.App_Start
{
    public static class InjectionInitializar
    {
        public static Container Initialize()
        {
            var container = new Container();
            container.Options.DefaultLifestyle =  Lifestyle.Scoped;
            

            container.Register<IDbContext, PetFinderContext>();
            container.Register<RacaService>();
            container.Register<IRacaService, RacaService>();
            container.Register<IRacaRepository, RacaRepository>();

            return container;
        }
    }
}