﻿using UETools.Core;
using UETools.Objects.Interfaces;

namespace UETools.Objects.Property
{
    internal sealed class LazyObjectProperty : UProperty<int>
    {
        public override void Deserialize(FArchive reader, PropertyTag tag) => reader.Read(out _value);
    }
}