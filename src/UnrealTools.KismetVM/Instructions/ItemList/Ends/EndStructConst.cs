﻿namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class EndStructConst : EndToken
    {
        public override EExprToken Expr => EExprToken.EX_EndStructConst;
    }
}
