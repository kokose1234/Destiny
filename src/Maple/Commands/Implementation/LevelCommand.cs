﻿using Destiny.Maple.Characters;

namespace Destiny.Maple.Commands
{
    public sealed class LevelCommand : Command
    {
        public override string Name
        {
            get
            {
                return "level";
            }
        }

        public override string Parameters
        {
            get
            {
                return "level";
            }
        }

        public override GmLevel RequiredLevel
        {
            get
            {
                return GmLevel.Gm;
            }
        }

        public override void Execute(Character caller, string[] args)
        {
            if (args.Length != 1)
            {
                this.ShowSyntax(caller);
            }
            else
            {
                caller.Level = byte.Parse(args[0]);
            }
        }
    }
}
