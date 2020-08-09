using BluBotCore.Other;
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluBotCore.Preconditions
{
    class RequireWYKBuild : PreconditionAttribute
    {
        public RequireWYKBuild()
        {
            //################### Not Required - Test before removing. ######################
        }

        /// <summary>Returns a PreconditionResult after evaluating the context with the requirements.</summary>
        /// <param name="context">Command context of the current message.</param>
        /// <param name="command">Command object</param>
        /// <param name="services">Injection service object</parem>
        /// <returns>PreconditionResult</returns>
        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            return Task.FromResult(PreconditionResult.FromSuccess());
        }
    }
}

