using System;
using System.Collections.Generic;

namespace DOL.GS.Quests
{
	public enum eStepCheckType : int
	{
		Qualification,
		Offer,
		GiveItem,
		Step,
		Finish,
		RewardsChosen,
		PostFinish,
	}

	public interface IDataQuestStep
	{
		bool Execute(DataQuest dataQuest, GamePlayer player, int step, eStepCheckType stepCheckType);
	}
}
