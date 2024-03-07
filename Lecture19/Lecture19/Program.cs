
/*
Modelová firma potřebuje softwarový systém pro správu svých zaměstnanců.
Vaším úkolem je vytvořit třídový diagram pro tento systém. Firma má následující požadavky:

Každý zaměstnanec má následující atributy: jméno, příjmení, datum narození, pozice, plat a oddělení, ve kterém pracuje.
Firma má několik oddělení, každé s vlastním názvem a vedoucím.
Zaměstnanci mohou být členy jednoho nebo více týmů. Každý tým má název a seznam členů.
Systém by měl umožňovat vyhledávání zaměstnanců podle různých kritérií, jako je jméno, příjmení, pozice nebo oddělení.
Firma chce také sledovat docházku zaměstnanců. Každý zaměstnanec má docházkový záznam s datem a časem příchodu a odchodu z práce.

Vytvořte třídový diagram pro tento systém, zahrnující potřebné třídy, atributy a vztahy mezi nimi.
*/

Company gymspit = new Company();

Employee zajic = new Employee();
zajic.FirstName = "Antonin";
zajic.LastName = "Zajic";

gymspit.Employees.Add(zajic);





// Dalsi genericke typy
Stack<Employee> stack = new Stack<Employee>();

Queue<Employee> queue = new Queue<Employee>();

LinkedList<Employee> list = new LinkedList<Employee>();


Dictionary<string, Employee> map = new Dictionary<string, Employee>();

map.Add("pavel", new Employee());

Employee aa = map["pavel"];




