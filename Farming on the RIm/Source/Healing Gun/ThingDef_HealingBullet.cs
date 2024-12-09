using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP
{
    public class ThingDef_HealingBullet : ThingDef 
    {
        public HediffDef HediffToRemove = HediffDefOf.BloodLoss;
    }
}
