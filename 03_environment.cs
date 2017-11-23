using System;

class Test
{
  static void Main( string[] args )
  {
    ShowEnvironmentDetails();   
    Console.Write("\nProgram ended normally\n");
  }

  static void ShowEnvironmentDetails()
  {
    foreach( string drive in Environment.GetLogicalDrives() ) {
      Console.WriteLine("Drive: {0}", drive);
    }

    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Version: {0}", Environment.Version);
  }

}


