using StudyGroup.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudyGroup.API.DAL
{
    public class AppleGetter : IAppleGetter
    {
        public Apple GetById(int id)
        {
            if (id == 0) return null;

            return new Apple
            {
                Cost = 12,
                Name = "Fuji",
                QuantityRemaining = 1
            };
        }
    }
}