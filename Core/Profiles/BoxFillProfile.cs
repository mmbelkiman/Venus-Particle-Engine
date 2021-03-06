﻿namespace VenusParticleEngine.Core.Profiles
{
    public class BoxFillProfile : Profile
    {
        public override void GetOffsetAndHeading(out Vector offset, out Axis heading)
        {
            offset = new Vector(FastRand.NextSingle(Width * -0.5f, Width * 0.5f),
                                     FastRand.NextSingle(Height * -0.5f, Height * 0.5f));

            FastRand.NextUnitVector(out heading);
        }
    }
}