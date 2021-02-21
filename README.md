# StarportExcel
Program for automating and organizing planets in Starport GE (Space Video Game I play)

Literally wrote this to better organize my planets in a video game...

uses .Net and Microsoft Office
".NETFramework,Version=v4.7.2"
Microsoft.Office.Interop.Excel 15.0.4795.1000;

To properly use this your planetary naming system must be (coordinates)CapitalFirstLetter-PlanetType in 3 letters Then planet number. (period) xxx (must be 3 things inbetween I'm using numbers on a unit circle but you can make this anything but i plan to use its location on a unit circle to have a bot fly to it in the future . (Then another period IF AND ONLY IF, its Zounds, Growing, Researching ,Needs Defense or is a Double dome, if its none of that forego this period)

So an example of a planetary name is (123, 321)Oce13.180.ZN (coordinates can be anywhere between 1 to 3 digits on the x and y coordinates so it can still be (23, 1) that is still okay if said coordinates exist in teh game. Anything before the parenthesis is irrelevant.

My planets will look like Panther(123, 321)Arc012.100.ZD

Its important to note you can have 000 to 999 planets maximum of that type I haven't accounted for anything more but you can represent your planet type as 2 digits or 3
so 010 is acceptable and 10 is acceptable

Table for stuff
Arc == Arctics
Des == Deserts (not desmond)
Ear == Earthlikes
Gre == Greenhouses
Mou == Mountains
Oce == Oceanics
Par == Paradises
Roc == Rockies
Vol == Volcanics

Return Planet button. In here you can put a number in the box or put coordinates in the box (it accepts brackets because it converts it parenthesis) Hitting the same system lsit is going to output all of it to output.txt or whatever you assigend it to .

Edit Planet Info is where you can copy the info from holdings into and put it in there. It finds builds for you and tells you if they're build worthy and generally is just for filling out all teh colony information.


Z == Zounds | Z Must be First
D == Double Dome | Must be After Z
G == Growing | R occupies the same space so cant be both Must be after Z
R == Research | G occupies the same space so can't be both Must be After Z
N == Needs Defense | Must be After G/R
I == Invaded | Must be Last


If you find any errors or bugs please tell me and how you reached it

Code created by Alexander Fields https://github.com/roku674 || https://www.linkedin.com/in/alexander-fields-aa57a997/

feel free to donate https://sites.google.com/view/perilousgamesltd/donate

Brave is a safe browser that doesn't track your data unless you want it to be tracked. You can then be paid (in cryptocurrency, but still paid nonetheless) for your data https://brave.com/rok079
