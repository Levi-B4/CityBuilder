﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class CityBuilder
    {
        public void CreateBuilding<T>(T building, City city) where T : Building
        {
            //Get Materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves(), city);

            if (buildingWasMade)
            {
                city.Buildings.Add(building);
            }
        }

        public bool ConstructBuilding<T>(List<Material> materials, bool permit, bool zoning, City city) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    var firstStep = material.MaterialConstructionFirstStep();
                    Console.WriteLine(firstStep);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
