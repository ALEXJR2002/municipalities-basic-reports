using System;

public class Municipality
{
	private string municipalityName;
	private string municipalityCode;
	private string municipalityType;
	private string departmentCode;
	private string departmentName;
	public Municipality(string mN, string mC, string mT, string dC, string dN)
	{
		municipalityName = mN;
		municipalityCode = mC;
		municipalityType = mT;
		departmentCode = dC;
		departmentName = dN;
	}
}
