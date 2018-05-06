﻿namespace FestivalManager
{
    using System.IO;
    using System.Linq;
    using Core;
    using Core.Contracts;
    using Core.Controllers;
    using Core.Controllers.Contracts;
    using Core.IO;
    using Core.IO.Contracts;
    using Entities;
    using Entities.Contracts;
    using FestivalManager.Entities.Sets;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Stage stage = new Stage();

            IFestivalController festivalController = new FestivalController(stage);
            ISetController setController = new SetController(stage);

            var engine = new Engine(writer, reader, festivalController);

            engine.Run();
        }
    }
}