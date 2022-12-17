       identification division.
       program-id. Chapter-4-Program-2.
******************************************
* Author - Johnathan Webster             *
******************************************
       environment division.
       Input-Output Section.
       File-Control.
           Select PayRoll-Master
               ASSIGN to 'C:\Data\Data-In\Ch4_payroll.dat'
               organization is line sequential.
           Select Payroll-Report
               Assign to 'C:\Data\Data-Out\Ch4_Payroll.rpt'
               organization is line sequential.

       configuration section.
       data division.


******************************************
* Set up file structure                  *
******************************************

       File Section.
       FD Payroll-Master.
       01 Payroll-Record.
         05 Employee-Number    pic X(05).
         05 Employee-Name      pic X(20).
         05 Location-Code.
           10 Territory        pic x(02).
           10 Office-Number    pic X(02).
         05 Annual-Sal         pic X(06).
         05 SSN                pic X(09).
         05 Department-Number  pic X(02).
         05 Job-Class          pic X(02).
         05 Filler             pic X(32).

       FD Payroll-Report.
       01 Report-Record.
         05 Filler             pic X(03).
         05 Rpt-Employee-Num   pic X(05).
         05 Filler             pic X(03).
         05 Rpt-Employee-Name  pic X(17).
         05 Filler             pic X(01).
         05 Report-Territory   pic X(02).
         05 Filler             pic X(02).
         05 Rpt-Office-Num     pic X(02).
         05 Filler             pic X(06).
         05 Rpt-Annual-Sal     pic X(06).
         05 Filler             pic X(03).
         05 Rpt-SSN            pic X(09).
         05 Filler             pic X(03).
         05 Rpt-Dpt-Num        pic X(02).
         05 Filler             pic X(05).
         05 Rpt-Job-Class      pic X(02).
         05 Filler             pic X(09).

******************************************
* Set Loop Contorl                       *
******************************************

       working-storage section.
       01 Assorted-Flags.
         05 More-Records       pic X(3) value 'YES'.
       01 Calculating-Fields.
         05 Calculate-Total-Price pic 9(6)v99 value 0.

******************************************
* Title                                  *
******************************************

       01 Print-Title1.
         05 Filler             pic X(22) value Spaces.
         05 Filler             pic X(10) value ' PAYROLL '.
         05 FIller             pic x(10) value 'LISTING  '.
         05 FIller             pic X(38) value Spaces.
******************************************
* Line Spacing                           *
******************************************

       01 Print-Break1.
         05 Filler             pic X(80) value Spaces.
******************************************
* Dashes for Report                      *
******************************************

       01 Print-Break2.
         05 Filler             pic x(12) value Spaces.
         05 Filler             pic X(10) value '----------'.
         05 Filler             pic X(10) value '----------'.
         05 Filler             pic X(10) value '----------'.
         05 Filler             pic X(10) value '----------'.
         05 Filler             pic X(28) value Spaces.

******************************************
* Record Header                          *
******************************************

       01 Print-Header1.
         05 Filler             pic X(03) value Spaces.
         05 Filler             pic X(06) value 'EMP NO'.
         05 Filler             pic X(02) value Spaces.
         05 Filler             pic X(08) value 'EMP NAME'.
         05 Filler             pic X(10) value Spaces.
         05 Filler             pic X(08) value 'TERR/OFF'.
         05 Filler             pic X(02) value Spaces.
         05 Filler             pic X(09) value '  ANN SAL'.
         05 Filler             pic X(01) value Spaces.
         05 Filler             pic X(11) value 'SOC SEC NUM'.
         05 Filler             pic X(01) value Spaces.
         05 Filler             pic X(04) value '#DEP'.
         05 Filler             pic X(01) value Spaces.
         05 Filler             pic X(09) value 'JOB CLASS'.
         05 Filler             pic X(05) value Spaces.

       procedure division.

******************************************
* Main Program                           *
******************************************

       100-Main-Module.
           Perform 110-Startup-Module.
           Perform Until More-Records = 'NO '
               Read Payroll-Master
                   At end
                       Move 'NO ' to More-Records
                   Not At end
                       Perform 200-Loop-Return
               End-Read
           end-perform.

           Perform 300-Close-Module.
           Stop run.

*********************************************
* Move data from report to specified format *
*********************************************

       110-Startup-Module.
           Open Input Payroll-Master
             Output Payroll-Report.

           Write Report-Record from Print-Title1.
           Write Report-Record from Print-Break2.
           Write Report-Record from Print-Break1.
           Write Report-Record from Print-Header1.
           Write Report-Record from Print-Break1.
********************************************
* Loop through each record and update info *
********************************************

       200-Loop-Return.
           Move Employee-Number to Rpt-Employee-Num.
           Move Employee-Name to Rpt-Employee-Name.
           Move Territory to Report-Territory.
           Move Office-Number to Rpt-Office-Num.
           Move Annual-Sal to Rpt-Annual-Sal.
           Move SSN to Rpt-SSN.
           Move Department-Number to Rpt-Dpt-Num.
           Move Job-Class to Rpt-Job-Class.

           write Report-Record.
           initialize Report-Record.

******************************************
* Close                                  *
******************************************

       300-Close-Module.
           Write Report-Record from Print-Break1.
           close Payroll-Master
                 Payroll-Report.

       end program Chapter-4-Program-2.
