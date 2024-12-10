using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace LAP
{
    public class Projectile_TranquilizingBullet : Bullet
    {
        public ThingDef_TranquilizingBullet Def
        { 
            get
            {
                return this.def as ThingDef_TranquilizingBullet;
            }
        }
            protected override void Impact(Thing hitThing, bool blockedByShield = false)
        {
            base.Impact(hitThing, blockedByShield);
            if (hitThing != null && hitThing is Pawn hitpawn)
            {
                var catatonicpawn = hitpawn?.health?.hediffSet?.GetFirstHediffOfDef(Def.HediffToAdd);
                if (catatonicpawn == null)
                {
                    Hediff hediff = HediffMaker.MakeHediff(Def.HediffToAdd, hitpawn, null);
                    hitpawn.health.AddHediff(hediff, null, null);
                }
            }
                

            }
        }
    }
