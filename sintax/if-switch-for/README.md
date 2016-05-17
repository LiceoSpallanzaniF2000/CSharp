#CSharp

##Ciclo if

###Sintassi

```  
	if ( *condizione* )  
	{  
		...  
	}  
	else if ( *condizione* )  
	{  
		...  
	}  
	else  
	{  
		...  
	}  
```

###Ricorda
* i simboli per i confonti sono  
	* a > b  
	* a < b  
	* a >= b  
	* a <= b  
	* a == b  
	* a != b  
* and --> &&  
* or  --> ||  

##Ciclo for

###Sintassi

```  
	for ( *dichiarazione e inizializzazione contatore* ; *condizione che deve continare a verificarsi* ; *incremento/decremento contatore*)
	{
		...
	}
``

###Ricorda
*i = i+1; == i+=1; == i++;
*i = i-1; == i-=1; == i--;
*i = i+2; == i+=2;
*i = i-2; == i-=2;

##Gestione degli errori con `try...catch`

##Sintassi
```
	try
	{
		...
	}
	catch
	{
		... (istruzioni che si eseguono quando all'interno del try avviene un errore)
	}	
```