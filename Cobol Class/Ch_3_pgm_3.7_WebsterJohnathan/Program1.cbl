       identification division.
       program-id. Ch3pgm7.

       environment division.
       Input-Output Section.
       File-Control.

           Select CUST-TRANS
               assign to 'C:\Data\Data-In\Ch3_Custtrans.dat'
               organization is line sequential.

           Select CUST-MASTER
               assign to 'C:\Data\Data-Out\Ch3_CustMaster.dat'
               organization is line sequential.

       configuration section.

       data division.
       File Section.
       FD CUST-TRANS.
       01 TRANS-REC.
         05 Ident-in           Pic X(05).
         05 Sale-in            Pic 9(3)v99.

       FD CUST-MASTER.
       01 MSTR-REC.
         05 Ident-out          Pic X(05).
         05 Sale-out           Pic 9(3)v99.
         05 Disc-Pcnt-out      Pic v99.
         05 Net-out            Pic 9(3)v99.

       working-storage section.
       01 More-Recs            Pic XXX value 'YES'.
       01 WS-Disc-Amt          Pic 9(3)99 value 0.

       procedure division.
     ************_MAIN_********
           
       100-MAIN-MODULE.
           PERFORM 110-OPEN-RTN.
           PERFORM until More-Recs = 'NO '
               READ CUST-TRANS
                   AT END
                       Move 'NO ' to More-Recs
                   Not At END
                       Perform 200-CALC-DISC
               END-READ
           END-PERFORM.
           PERFORM 300-CLOSE-RTN.

           goback.
***********_Open_File_************************
       110-OPEN-RTN.
           Open Input CUST-TRANS Output CUST-MASTER.

***********_Peform_Calculations_************************

       200-CALC-DISC.
           Initialize MSTR-REC.
           Move Ident-In to Ident-Out.
           Move Sale-In to Sale-Out.
           If Sale-In > 100.00
               Move .03 to Disc-Pcnt-Out
               Multiply Sale-In by 0.03 giving WS-Disc-Amt
           Else
               Move .02 to Disc-Pcnt-Out
               Multiply Sale-In by 0.02 giving WS-Disc-Amt
           End-If.
           subtract WS-Disc-Amt from Sale-In giving Net-Out.
           Write MSTR-REC.
***********_Housekeeping_************************

       300-CLOSE-RTN.
           Close CUST-TRANS
             CUST-MASTER.

       end program Ch3pgm7.
