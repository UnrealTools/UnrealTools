﻿using UETools.Core;
using UETools.Objects.Package;

namespace UETools.Objects.KismetVM.Instructions
{
    internal sealed class ObjectConst : ConstToken<ObjectReference>
    {
        public override EExprToken Expr => EExprToken.EX_ObjectConst;

        public override FArchive Serialize(FArchive archive)
            => base.Serialize(archive)
                   .Read(ref _value);
    }
}
