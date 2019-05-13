using System;
using System.Threading.Tasks;

namespace Schwi
{
    public class Schwi
    {
        public static void Main(string[] args)
            => new Schwi().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {

        }
    }
}
