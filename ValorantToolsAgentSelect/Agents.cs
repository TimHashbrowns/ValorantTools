using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantToolsAgentSelect
{
	public static class Agents
	{
		private static Random rnd = new Random();

		private static List<string> agents { get; set; } = new List<string>()
		{ "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Fade", "Harbor", "Jett", "KAY/O", "Killjoy", "Neon", "Omen", "Phoenix", "Raze",
			"Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };

		public static string GetRandom()
		{
			int index = rnd.Next(agents.Count);

			return agents[index];
		}

		public static string IfTaken()
		{
			int result = rnd.Next(2);

			//return result;
			return result == 1 ? "Next" : "Previous";
		}
	}
}
