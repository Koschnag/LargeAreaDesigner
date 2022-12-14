using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeAreaDesigner.Models
{
    public class Wunsch
    {
        public bool Bewässerungsanlage { get; set; } = false;
        public bool Blumen { get; set; } = false;
        public bool Nadelbäume { get; set; } = false;
        public bool Laubbäume { get; set; } = false;
        public bool Büsche { get; set; } = false;
        public bool Teich { get; set; } = false;

        public Aufwand Pflegeaufwand { get; set; } = Aufwand.Undefiniert;
        public Material Gartenwege { get; set; } = Material.Undefiniert;
    }

    public class WunschValidator : AbstractValidator<Wunsch>
    {
        public WunschValidator()
        {
            RuleFor(x => x.Pflegeaufwand).NotEqual(Aufwand.Undefiniert);
            RuleFor(x => x.Gartenwege).NotEqual(Material.Undefiniert);
        }
    }

    public enum Aufwand
    {
        Undefiniert,
        Egal,
        Niedrig,
        Mittel,
        Hoch
    }

    public enum Material
    {
        Undefiniert,
        Egal,
        Kies,
        Beton,
        Sandstein,
        Splitt,
        Marmor,
        Tuff,
    }
}