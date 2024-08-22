using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Enums
{
    public enum VehicleColor
    {
        [Display(Name = "RED")]
        Red =1,
        [Display(Name = "BLUE")]
        Blue =2,
        [Display(Name = "BLACK")]
        Black =3,
        [Display(Name = "WHITE")]
        White =4
    }
}
