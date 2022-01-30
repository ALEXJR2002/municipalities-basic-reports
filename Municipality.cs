using System;

public class Municipality
{
	public string municipalityName { get; set; }
	public string municipalityCode { get; set; }
	public string municipalityType { get; set; }
	public string departmentCode { get; set; }
	public string departmentName { get; set; }
	public Municipality(string mN, string mC, string mT, string dC, string dN)
	{
		municipalityName = mN;
		municipalityCode = mC;
		municipalityType = mT;
		departmentCode = dC;
		departmentName = dN;
	}
}
