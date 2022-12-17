       identification division.
       program-id. Program16sub as 'INFLTN'.

       environment division.
       configuration section.

       data division.

       linkage section.

       01 DATA-CALCULATION1.
         05 COST-CALC          pic 9(03)v9(02).
         05 INFLATION-CALC     pic 99.
         05 YEAR-CALC          pic 99.


       

       procedure division using DATA-CALCULATION1.

       100-Main-Module.
           if YEAR-CALC <= 5
               compute COST-CALC rounded = COST-CALC * 1.05
               move 5 to INFLATION-CALC
           else
               compute COST-CALC rounded = COST-CALC * 1.10
               move 10 to INFLATION-CALC
           end-if
           goback.

       end program Program16sub.
