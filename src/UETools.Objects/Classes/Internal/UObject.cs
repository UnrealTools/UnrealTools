﻿using UETools.Core;

namespace UETools.Objects.Classes.Internal
{
    public class UObject : TaggedObject
    {
        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            reader.Read(out _wasKill);
        }

        private bool _wasKill;
    }
}