﻿using System.IO;
using UETools.Core;
using UETools.Core.Interfaces;

namespace UETools.Objects.KismetVM.Instructions
{
    internal abstract class CallToken<T> : Token where T : notnull, IUnrealDeserializable, new()
    {
        public T CallTo => _callTo;
        public TokenList Params { get; } = new TokenList();

        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            reader.Read(out _callTo);
            Params.ReadUntil(reader, EExprToken.EX_EndFunctionParms);
        }
        public override void ReadTo(TextWriter writer)
        {
            writer.Write($"{Expr} {CallTo} (");
            var i = 0;
            foreach (var item in Params.Items)
            {
                if (i++ != 0)
                    writer.Write(", ");

                item.ReadTo(writer);
            }
            writer.WriteLine(")");
        }

        private T _callTo = default!;
    }
}