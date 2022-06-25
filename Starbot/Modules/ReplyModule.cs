using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbot.Modules
{
    public class ReplyModule : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        [Summary("Echos a message")]
        public Task SayAsync([Remainder][Summary("The text to echo")] string echo) 
            => ReplyAsync(echo);
    }
}
