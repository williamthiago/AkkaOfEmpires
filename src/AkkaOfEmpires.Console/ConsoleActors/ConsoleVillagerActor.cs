﻿using Akka.Actor;
using AkkaOfEmpires.Units;
using System;
using AkkaOfEmpires.Domain.Commands;

namespace AkkaOfEmpires.ConsoleUI.ConsoleActors
{
    public class ConsoleVillagerActor : VillagerActor
    {
        public ConsoleVillagerActor(IActorRef resourcesSupervisor)
            : base(resourcesSupervisor)
        {
        }

        protected override void PreStart()
        {
            Console.WriteLine("A new villager appears!");
            base.PreStart();
        }

        protected override void ResourceHarvester(IHarvestResourceCommand command)
        {
            Console.WriteLine("Villager becomes {0}", command.AssociatedProfession);
            base.ResourceHarvester(command);
        }

        protected override void ResourceCarrier(uint quantity)
        {
            Console.WriteLine("Villager carries {0} {1}", quantity, ResourceToRecolt);
            base.ResourceCarrier(quantity);
        }
    }
}