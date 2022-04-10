using ValorantToolsAgentSelect;

string agentStatement = $"Agent: { Agents.GetRandom() }";
string ifTakenStatement = $"If taken: { Agents.IfTaken() }";

Console.WriteLine(agentStatement);
Console.WriteLine(ifTakenStatement);