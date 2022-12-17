       identification division.
       program-id. Program10.

       environment division.
       input-output section.
       file-control.
           select payroll-in assign to 
           'C:\Data\Data-In\Ch10_payroll.dat'
               organization is line sequential.
           select report-out
               assign to 'C:\Data\Data-Out\2022ch10out.rpt'
               organization is line sequential.
       configuration section.

       data division.
       file section.
       FD payroll-in.
       01 emp-rec-in.
         05 employee-no        pic x(05).
         05 employee-name      pic x(20).
         05 territory-no       pic x(02).
         05                    pic x(02).
         05 annual-salary      pic 999999.
         05                    pic x(45).

       FD report-out.
       01 print-rec            pic x(80).

       working-storage section.

       01 ws-date.
         05 ws-year            pic 9999.
         05 ws-month           pic 99.
         05 ws-day             pic 99.

       01 heading1.
         05                    pic x(30) value spaces.
         05                    pic x(27) value
                               'total salaries by territory'.
         05                    pic x(03) value spaces.
         05 heading-date.
           10 heading-day      pic 99.
           10                  pic x value '/'.
           10 heading-month    pic 99.
           10                  pic x value '/'.
           10 heading-year     pic 9999.
         05                    pic x(12) value spaces.

       01 heading2.
         05                    pic x(10) value spaces.
         05                    pic x(13) value 'territory no.'.
         05                    pic x(07) value spaces.
         05                    pic x(14) value 'total salaries'.
         05                    pic x(36) value spaces.

       01 heading3.
         05                    pic x(30) value spaces.
         05                    pic x(26) value
                               'total salaries for company'.
         05                    pic x(03) value spaces.
         05 total-company-salary pic $zzz,zzz,zzz.99.
         05                    pic x(06) value spaces.

       01 total-records.
         05                    pic x(14) value spaces.
         05 territory-out      pic x(02).
         05 filler             pic x(17).
         05 total-salary       pic $999,999.99.
           77 are-there-records    pic xxx value 'yes'.
           77 first-record         pic xxx value 'yes'.
           77 ws-terr-hold         pic x(02).
           77 ws-total-salary      pic 9(09)v99.
           77 totals               pic 9(09)v99.

       procedure division.

       100-Main-Module.
           perform 400-Initialization-Return
           perform 500-Heading-Return
           perform until are-there-records = 'no'
               read payroll-in
                   at end
                       move 'no' to are-there-records
                   not at end
                       perform 200-Detail-Return
               end-read
           end-perform.

           compute totals = totals + ws-total-salary
           move totals to total-company-salary
           perform 300-Control-Break
           write print-rec from heading3
           after advancing 2 lines
           perform 600-end-Of-Job-Return
           goback.

       200-Detail-Return.
           evaluate true
               when first-record = 'yes'
                   move territory-no to ws-terr-hold
                   move 'no' to first-record
               when territory-no not = ws-terr-hold
                   compute totals = totals + ws-total-salary
                   perform 300-Control-Break
           end-evaluate
           move territory-no to territory-out
           move annual-salary to total-salary
           compute ws-total-salary = ws-total-salary + annual-salary.

       300-Control-Break.
           move ws-total-salary to total-salary
           write print-rec from total-records
             after advancing 2 lines
           move 0 to ws-total-salary
           move 'yes' to first-record.

       400-Initialization-Return.
           open input payroll-in
             output report-out.

       500-Heading-Return.
           move function current-date to ws-date
           move ws-year to heading-year
           move ws-month to heading-month
           move ws-day to heading-day
           write print-rec from heading1
             after advancing 2 lines
           write print-rec from heading2
             after advancing 2 lines.

       600-End-Of-Job-Return.
           close payroll-in
             report-out.
       end program Program10.
