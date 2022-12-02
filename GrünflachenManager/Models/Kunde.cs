using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrünflachenManager.Models;

public class Kunde
{
    public string Vorname { get; set; } = "Neuer";
    public string Name { get; set; } = "Kunde";
    public string TelefonPrivat { get; set; } = string.Empty;
    public string TelefonMobil { get; set; } = string.Empty;
    public decimal Budget
    {
        get => Budget;
        set
        {
            if (Budget == value)
                return;

            Budget = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
        }
    }

    public Wunsch? Wunsch { get; set; }

    #region Addresse

    public string Anschrift { get; set; } = string.Empty;
    public string Ort { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string PLZ { get; set; } = string.Empty;
    public string Land { get; set; } = "Deutschland";

    #endregion
}
