using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace PL
{
    public class IngestionOutcomeDoer_RemoveHediff : IngestionOutcomeDoer
    {
        public HediffDef removeThisThing;
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int Thing)
        {
            var toxicHediff = pawn.health.hediffSet.GetFirstHediffOfDef(removeThisThing);
            if (toxicHediff != null)
            {
                pawn.health.hediffSet.hediffs.Remove(toxicHediff);
            }
        }
    }
}
