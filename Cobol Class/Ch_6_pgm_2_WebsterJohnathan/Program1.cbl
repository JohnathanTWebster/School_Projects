       identification division.
       program-id. Ch6pgm2.
      *******************************************
      * Chapter 6.2 - Johnathan Webster         *
      *******************************************
       environment division.
       Input-output section.
       File-control.
           select Payroll-Master
               assign to 'C:\Data\Data-In\Ch6_402mod.dat'
               organization is line sequential.
           select Payroll-Report
               assign to 'C:\Data\Data-Out\Ch6_Paydisk.rpt'
               organization is line sequential.

       configuration section.
       data division.
       File section.
       FD Payroll-Master.
       01 Payroll-Record.
         05 Employee-Number    pic x(05).
         05 Employee-Name      pic x(20).
         05 Location-Code.
           10 Territory        pic x(02).
           10 Office-Number    pic x(02).
         05 Annual-Salary      pic x(06).
         05 SSN                pic x(09).
         05 Filler             pic x(36).

       FD Payroll-Report.
       01 Report-Record.
         05 Filler             pic x(04).
         05 Report-Emp-Num     pic x(05).
         05 Filler             pic x(02).
         05 Report-Emp-Name    pic x(20).
         05 Filler             pic x(01).
         05 Report-Territory   pic x(02).
         05 Filler             pic x(02).
         05 Report-Office-Num  pic x(02).
         05 Filler             pic x(03).
         05 Report-Ann-Sal     pic x(06).
         05 Filler             pic x(03).
         05 Report-SSN         pic x(09).
         05 Filler             pic x(21).


       working-storage section.
       01 Assorted-Flags.
         05 More-Records       pic x(3) value 'YES'.
         05 WS-PageNum         pic 9(3) value zero.
         05 Employee-Count     pic 9(03) value zero.
         05 Line-Count         pic 9(02) value zero.
         05 WS-Date.
           10 WS-YY            pic 9(02).
           10 WS-MM            pic 9(02).
           10 WS-DD            pic 9(02).
       01 Print-Title1.
         05 Filler             pic x(20) value spaces.
         05 Filler             pic x(08) value 'Payroll '.
         05 FIller             pic x(08) value 'Listing '.
         05 Filler             pic x(08) value spaces.
         05 Filler             pic x(05) value 'Page:'.
         05 Report-PageNum     pic z99.
         05 Filler             pic x(03) value spaces.
         05 Report-Date.
           10 Report-Month     pic 9(02).
           10 Filler           pic x value '/'.
           10 Report-Day       pic 9(02).
           10 Filler           pic x value '/'.
           10 Report-Year      pic 9(04).
         05 Filler             pic X(15) value spaces.
       01 Print-Pagebreak1.
         05 Filler             pic x(80) value spaces.
       01 Print-Total1.
         05 Filler             pic x(10) value spaces.
         05 Filler             pic x(10) value 'Total # Em'.
         05 Filler             pic x(10) value 'ployees li'.
         05 Filler             pic x(07) value 'sted: '.
         05 Total-Count        pic zz9.
         05 Filler             pic x(40).
       01 Print-Header1.
         05 Filler             pic x(03) value spaces.
         05 Filler             pic x(06) value 'Emp No'.
         05 Filler             pic x(02) value spaces.
         05 Filler             pic x(13) value 'Employee Name'.
         05 Filler             pic x(07) value spaces.
         05 Filler             pic x(08) value 'Terr/Off'.
         05 Filler             pic x(01) value spaces.
         05 Filler             pic x(07) value 'Ann Sal'.
         05 Filler             pic x(02) value spaces.
         05 Filler             pic x(11) value 'Sov Sec Num'.
         05 Filler             pic x(20) value spaces.

       procedure division.

      ********************************************
      * Main Program                             *
      ********************************************

       100-Main-Module.
           perform 110-Startup-Module.
           perform until More-Records = 'No '
               read Payroll-Master
                   at end
                       move 'No ' to More-Records
                   not at end
                       perform 200-Loop-Return
               end-read
           end-perform.
           perform 300-Close-Module.
           stop run.

      *********************************************
      * Start module                              *
      *********************************************
       110-Startup-Module.
           open input Payroll-Master
             output Payroll-Report.

           move 1 to WS-PageNum
           accept WS-Date from date
      *Display date
           move WS-MM to Report-Month
           move WS-DD to Report-Day
           add WS-YY 2000 giving Report-Year
           move WS-PageNum to Report-PageNum

           write Report-Record from Print-Title1.
           write Report-Record from Print-Pagebreak1.
           write Report-Record from Print-Header1.
           move 3 to Line-Count.

      *********************************************
      * Loop until line count exceeds or meets 60 *
      *********************************************

       200-Loop-Return.
           if Line-Count < 60
               continue
           else
               perform 210-Page-Break-Module
           end-if

           move spaces to Report-Record.
           move Employee-Number to Report-Emp-Num
           move Employee-Name to Report-Emp-Name
           move Territory to Report-Territory
           move Office-Number to Report-Office-Num
           move Annual-Salary to Report-Ann-Sal
           move SSN to Report-SSN
           add 1 to Employee-Count Line-Count
           write Report-Record.

      *********************************************
      * Break if line count exceeds page          *
      *********************************************
       210-Page-Break-Module.
           add 1 to WS-PageNum.
           move WS-PageNum to Report-PageNum
           write Report-Record from Print-Title1 after page.
           write Report-Record from Print-Pagebreak1.
           write Report-Record from Print-Pagebreak1.
           write Report-Record from Print-Header1.
           move 3 to Line-Count.

       300-Close-Module.
           move Employee-Count to Total-Count.
           write Report-Record from Print-Pagebreak1.
           write Report-Record from Print-Total1.
           close Payroll-Master Payroll-Report.
       end program Ch6pgm2.
