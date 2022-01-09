using ChainOfResponsibilityHM;


GarageCheck garageCheck=new GarageCheck();  
MechaniCheck mehaniCheck=new MechaniCheck();
ElectroiniCheck electroiniCheck = new ElectroiniCheck();    
DiagnostiCheck diagnostiCheck=new DiagnostiCheck(); 

garageCheck.setnext(mehaniCheck);   
mehaniCheck.setnext(electroiniCheck);
electroiniCheck.setnext(diagnostiCheck);
diagnostiCheck.setnext(null);

garageCheck.Handle();


Console.ReadLine();
