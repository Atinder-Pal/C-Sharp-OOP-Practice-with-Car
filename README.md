# c-review-oop-practice---car-class-Atinder-Pal
c-review-oop-practice---car-class-Atinder-Pal created by GitHub Classroom

**Author:** Atinder Pal
**Purpose:** 
This practice is designed to help get familiarization with object reference properties, access modifiers and encapsulation.

**Requirements:**
“Car” Class created:
**Properties:**
1. “Make” (Chevrolet, Nissan, Toyota)
2. “Model” (Camry, Corolla, Cruze)
3. “Color” (Red, Green, Blue, Black)
4. “MaximumOccupancy” (Number of Seats)
5. “FuelEfficiency” (Number of KM per Litre, can have decimals)
6. “Odometer” - object reference
7. “FuelTank” - object reference.

**Methods:**
1. Drive() and Drive(km) - call BurnFuel() and Increment() on the fuel tank and odometer, respectively, according to fuel efficiency.
2. A ToString() override that will output the format “A Blue Chevy Cruze with 060050KM on the odometer, that has enough fuel to travel 65KM.”

Both a default and greedy constructor (initialize object references as a new instance).</br>

“Odometer” Class created:</br>
**Properties:**
“Counter” with a getter and a private setter</br>
Perform reset validation in the counter’s setter.
If the new value would go over 999999, reset it to 0 and apply the excess (for example, 999980 + 40 = 20). 

**Methods:**
Increment(amount) </br>
Add “amount” to the “Counter” property. </br>
Default constructor that initializes the counter at 0.</br>

“FuelTank” Class created:
**Properties:**
1. “Capacity”, a decimal value in litres, with a private setter
2. “Level”, a decimal value in litres, with a private setter
Throw an exception if a value below 0 is incoming.
Clamp the value at the capacity.

**Methods:**
BurnFuel(litres)
Subtract “litres” from the “Level” property.
Fill(litres)
Add “litres” to the “Level” property.
Write a default constructor that initializes “Capacity” at 50 and “Level” at 50.

**Link To Trello Board:** https://trello.com/b/vmRwG4tg/oop-practice-car-class
