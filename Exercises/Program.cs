using System;

class Program{
	public static void Main(string[] args){
		Assignments a = new Assignments();
		// This makes an new Object with the parameter being the Name we will handle in our Class Customer

		CustomerDatabase database = new CustomerDatabase();

		// Adding new Customer objects to the database
		database.AddCustomer(new Customer("Alice", 101, 500.0)); // Alice is a Customer object
		database.AddCustomer(new Customer("Bob", 102, 300.0));   // Bob is a Customer object
		database.GetCustomerBalanceById(102);
	}
}



class Assignments  {
	public void dice(){
		/*
		Skriv et program, hvori
		1. Værdien af et terningeslag er gemt i en variabel ved navn dice.

			•Hvilken type giver det mening at erklære variablen som?
			•Vælg selv en specifik værdi.


		2. Opret en boolsk variabel og tildel den en værdi der repræsenterer 
		hvorvidt værdien fra variablen dice er lige og større end 3.

		3. Udskriv den værdien af denne boolske variabel.


		*/

		int dice = 3; //Definerer vores vilkårlige tal
		bool answer; //Vores boolean

		// 1. Integer fordi vi har at gøre med tallene 1..6, som alle er heltal.

		if (dice >= 3 && dice%2 != 0) { // Her beregner vi hvorvidt vores værdi er større eller = 3 og om tallet er lige ved ar bruge modolu 2 
			 answer = true;
			 Console.WriteLine(answer);
		};
	}
	//------------------------------------------------------------------------------------------------

	public void juleUdsalg(){
		/* 
		9.3 Juleudsalg 

		Skriv et program, hvori

		1. En variabel oprettes (erklæres) og initialiseres til værdien 21816000. Dette
		tal repræsenterer et antal sekunder siden nytår (alle måneder antages at
		være 30 dage lange).

		2. En anden variabel indeholder en pris på 599,95 dkr.
		3. Der skal gives et 30% rabat hvis det er Jul. Find selv på en fornuftig
		definition af hvornår det er Jul.
		4. Udregn den gældende pris (eventuelt rabat medregnet) og gem denne i en
		variabel.
		5. Udskriv denne variabel.
		6. Sørg for at teste den logik I har skrevet ved at prøve at tildele den første
		variable forskellige andre værdier. Hvilke værdier vil være fornuftige at
		teste?
		*/

		int year = 31556926;
		int time = 21816001;
		float price = 599.95F;
		float december = (year/(12/11));
		float newPrice = (price * 70)/100;

		if (december<=time){

			Console.WriteLine(newPrice);
		} else {
			Console.WriteLine(price);
		}
	}
	//------------------------------------------------------------------------------------------------


	public void dateDiff(){
		/* 
		Skriv et program, der givet 7 dagstemperaturer udregner og udskriver temper-aturdifferencen 
		mellem alle to på hinanden følgende dage 
		(dvs. Tirsdag-Mandag,Onsdag-Tirsdag . . . Søndag-Lørdag).

		*/

		float[] data = {21.5F,23.7F,19.6F,22.5F,25.3F,21.7F,18.9F};


		float[] diff(float[] array){
			float[] diffs = new float[array.Length-1]; 

			for (int i=0;i<diffs.Length; i++){
				diffs[i] = array[i+1]-array[i]; //Fratrækker næste iteration med nuværende
			}

			return diffs;
		}

		Console.WriteLine("[{0}]", string.Join(", ", diff(data)));

	}
	//------------------------------------------------------------------------------------------------


	public void sudokuPretty(){
		/*
		Skriv et program, hvori

		1. Ovenstående datastruktur er defineret.
		2. En metode er defineret der som parameter tager en sådan struktur ogskriver den ud på skærmen.
			•Hvilken prototype (i.e., returværdi og signatur) skal denne metodehave?
			•Skal man udprinte en række af gangen eller en søjle af gangen?
			•Hint:MetodenConsole.Write gør det samme som Console.WriteLine 
			men undlader at bryde linjen.
		3. Noget kode kalder denne metode.14.4 
		*/


		//For at kalde den i main: a.sudokuPretty();


		// Først skal vi definere vores Sudoku plade. Til dette anvender vi en int array. 
		// Det vigtigt at vi her fortæller, at vores array både har kolonner og rækker. Derfor anvendes [][]
		// Ligeledes bruger new int[][], fordi dette gør, at vi kan ændrer på størrelsen af arrayet inde i arrayet


		int[][] sudokuPlade = new int[][]{
			new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
            new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
            new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
            new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
            new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
            new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
            new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
            new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
            new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
		};


		// Nu skal vi loopet igennem arrayet
		for (int i=0;i< sudokuPlade.Length;i++){ //Her looper vi hver række

			//Hvis vi gerne vil have nogle streger i mellem vores værdier(blokke), anvendes nedenstående kode
			if(i%3==0 && i != 0 ){
				Console.WriteLine("---------------------");
			}

			// Nu skal vi loope vores kolonner
			for(int j=0;j<sudokuPlade[i].Length;j++){ //Her fortæller den, at for hver iteration(gentagelse), skal den køre et loop.
				if(j%3==0 && j!=0){
					Console.Write("| "); //Samme som vores vandrette linje, dog nu lodret
				}
				Console.Write(sudokuPlade[i][j] + " "); //Printer vores værdi hvert felt. Bemærk at koden ovenfor køres
														//først, hvilket betyder, at den indsætter stregen, hvis statement er rigtigt først.
			}
			Console.WriteLine(); //Bruges til at sige, at hver gang vi har fuldført en række, så skal den afslutte
								 //Ved at gå en række ned. Derfor afslutter hver iteration med dette. 
		}
	}
	//------------------------------------------------------------------------------------------------

	public int fakultet(int f){

		/*
		1. En metode udregner fakultet18(e.g.,fac(4) = 4·3·2·1) uden brug af etloop.
			•Hint: Dette kan gøres ved hjælp af rekursion.
		2. Noget kode kalder denne metode og udskriver resultatet
		*/


		//For at kalde den i main: a.fakultet(int);



		if(f==1 || f==0){ // Først sikrer vi, at vi ikke sætter nogle værdier ind, som kan give os en fejl i console
			return 1; // Returnerer 1, hvis dette er tilfældet
		} else {
			return f*fakultet(f-1); // Denne del er lidt tricky. Derfor forklarer jeg nedenfor hvad der sker. 
		}
		/*
		Som givet i hintet, så skal vi anvende rekursion. Så hvis vi starter i toppen, har vi vores
		method med en ukendt værdi 'int f'. Dette er vores ønskede fakultets nummer. Som beskrevet ovenfor, tjekker vi
		om vores nummer er 0 eller 1 og hvis dette er tilfældet, skal den returnere 1. Lad os nu springe end til hvis dette 
		ikke er tilfældet, så siger vi egentlig at den skal returnere f(vores ønsket fakultet) eks. 5. Dette skal den gange 
		methoden selv -1, så altså fakultet(4) f.eks. Dette betyder at vi samme tid kører methoden igen, men denne gang 4.

		Hvis man forstår den ovenstående tekst, forstår man nu også, at vi nødt til at have en måde hvorpå dette "loop"(rekursion)
		skal stoppe på. Det betyder ligeledes vores if statement sørger for, at vi stopper, hvis vores værdi er 0 eller 1. 

		*/

	}
	//------------------------------------------------------------------------------------------------

	public void circ(){
		/*
		Skriv et program der udregner og udskriver både arealet (π·r2) og omkredsen(2·π·r) af 
		tre cirkler med radius på hhv. 1, 3 og 5
		*/

		//For at kalde den i main: a.circ(); 

		int[] radius = {1, 3, 5};

		foreach (int r in radius){ // For int værdi (1, 3, 5) indsæt og kør nedenstående.
			double areal = Math.PI * r * r;
			double omkreds = 2 * Math.PI * r;
			Console.WriteLine("Vores radius: " + r);
			Console.WriteLine("Vores areal: " + Double.Round(areal,2));
			Console.WriteLine("Vores omkreds: " + Double.Round(omkreds,2)); // Double.Round(variable, antal decimaler)
			Console.WriteLine("---------------------");
		}
	}
	//------------------------------------------------------------------------------------------------
 	public double CalculateSqrt(double number){
		// Indsæt nedenstående i main for at få resultatet 
        // double input = 9;
		// double squareRoot = a.CalculateSqrt(input);
        // Console.WriteLine($"Kvadratroden af {input} er ca. {squareRoot}");

        double increment = 1_000_000_000; // Start med det største ciffer
        double currentValue = 0.0; // Nuværende værdi

        // Loop over cifrene fra 1 milliard til 0.000000001
        while (increment >= 0.000000001)
        {
            while (currentValue + increment <= Math.Sqrt(number))
            {
                currentValue += increment; // Læg den nuværende værdi til
            }
            increment /= 10; // Reducer for næste ciffer
        }

        return Math.Round(currentValue, 7); // Rund resultatet til 7 decimaler
    } 

}

class Customer {
	// Attributes - These are fields that store data for the object. We declare them here, and they will be used throughout the class and can be modified.
	// These fields are accessible from the main method whenever we create an instance of this class (i.e., a Customer object).
	public string Name;
	public int Id;
	public double Balance;

	// Constructor - This method is called automatically when we create a new Customer object. It takes name and id as parameters, which must be passed
	// when creating the object. The constructor initializes the Name and Id, and it sets the Balance to 0.0, assuming this is a new customer.
	public Customer(string name, int id)
	{
		Name = name;
		Id = id;
		Balance = 0.0;
	}

	// Constructor - This second constructor allows us to create a Customer object with an initial balance.
	// It takes name, id, and balance as parameters. This is useful if the customer has a pre-existing balance or makes an initial deposit.
	public Customer(string name, int id, double balance)
	{
		Name = name;
		Id = id;
		Balance = balance;
	}
	/*
	Why are we making two separate constructors?
	We are creating two constructors because we want to handle two different scenarios:
	1. The first constructor handles the case where we have a completely new customer. In this case, we assume the starting balance is 0.
	2. The second constructor handles the case where we want to register a customer with an existing balance or they make an initial deposit along with their registration.
	*/

	// Method - This method is used to handle deposits. The parameter 'amount' represents how much money the customer wants to deposit.
	// When we call aCustomer.Deposit(amount), the specified amount is added to the balance.
	// If we provide a negative value for 'amount', it could also subtract from the balance, meaning this method could technically handle both deposits and withdrawals.
	public void Deposit(double amount)
	{
		Balance += amount; // Adds the specified amount (positive or negative) to the balance.
	}

	// Method - This method is specifically for handling withdrawals. It includes a conditional statement to check whether the customer has enough
	// money in their balance to make the withdrawal. If the balance is sufficient, the amount is subtracted; otherwise, an error message is shown.
	public void Withdraw(double amount)
	{
		if (Balance >= amount)
		{
			Balance -= amount; // Subtracts the desired amount from the account 
		}
		else
		{
			Console.WriteLine("Ikke nok penge på kontoen til at foretage hævning.");
		}
	}

	// Method - This method returns the customer's current balance. We can call it whenever we want to check the balance.
	public double GetBalance()
	{
		return Balance;
	}
}

class CustomerDatabase{
public Customer[] customers;

    // Constructor that initializes the 'customers' array with 10 empty slots
    public CustomerDatabase()
    {
        customers = new Customer[10]; // Array with 10 slots
    }

    // Adds a customer to the first empty slot
    public void AddCustomer(Customer customer)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] == null)
            {
                customers[i] = customer;
                return;
            }
        }
        Console.WriteLine("No empty slots available to add a new customer.");
    }

    // Removes a customer by ID
    public void RemoveCustomerById(int id)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null && customers[i].Id == id)
            {
                customers[i] = null; // Remove the customer by setting the slot to null
                return;
            }
        }
        Console.WriteLine($"Customer with ID {id} not found.");
    }

    // Returns the entire customers array
    public Customer[] GetAllCustomers()
    {
        return customers;
    }

    // Prints the names of all customers
    public void PrintAllCustomerNames()
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null)
            {
                Console.WriteLine(customers[i].Name);
            }
        }
    }

	public double GetCustomerBalanceById(int id)
	{
		for (int i = 0; i < customers.Length; i++)
		{
			if (customers[i] != null && customers[i].Id == id)
			{
				Console.WriteLine(customers[i].Balance);
				return customers[i].Balance; // Return customer balance
			}
		}
		Console.WriteLine($"Customer with ID {id} not found.");
		return -1; // Return -1 to indicate the customer was not found
	}
}











