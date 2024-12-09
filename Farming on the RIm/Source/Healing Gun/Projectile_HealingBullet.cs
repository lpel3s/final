using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP
{
    public class Projectile_HealingBullet : Bullet
    {
        public ThingDef_HealingBullet Def
        {
            get
            {
                return this.def as ThingDef_HealingBullet;
            }
        }
        protected override void Impact(Thing hitThing, bool blockedByShield = false)
        {
            base.Impact(hitThing, blockedByShield);
            if (hitThing != null && hitThing is Pawn hitPawn)
            {
                var cutPawn = hitPawn?.health?.hediffSet?.GetFirstHediffOfDef(Def.HediffToRemove);
                if (cutPawn != null)
                {
                    hitPawn.health.hediffSet.hediffs.Remove(cutPawn);
                    }
            }
        }
    }
}
