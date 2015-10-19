Thank you for using HYDROFLO 2.0

HYDROFLO is a small hydraulic system designer
for circular, full pipe, incompressible flow.
You can solve for steady-state flows and head
losses throughout a fluid conveyance system.


Problems installing under Windows 95/98/Me

When installing, if you get an error that states
"1155: File INSTMSIA.EXE not found" you need to
update your OS with Windows installer Version 2.0.
It can be found at...
http://www.microsoft.com/downloads/details.aspx?displaylang=en&FamilyID=CEBBACD8-C094-4255-B702-DE3BB768148F 
or search for "Windows Installer" from the
Microsoft's website.


LIMITS...

The Academic version of HYDROFLO has maximums of...
  Parallels         9
  Supplys           2
  Gauges           32
  Valve/fittings   20
  Pipes            20
  Pumps             3
  FVHs              3
these limits allow you to solve the sample problems.

The maximums for the full version are...
  Elements        999
  Parallels         9
  Supplys           2
  Gauges          500
  Valves/fittings 500
  Pipes           500
  Pumps            20
  FVHs             50



INSTALLATION

HYDROFLO must be installed by a user with
Administrative Rights. However, it DOES NOT
need to be run with administrative rights.
HYDROFLO will be installed for ALL users on
a given PC.


TECHNICAL SUPPORT via support@tahoesoft.com

Please attach your data file to your email if
you have questions on a specific design issue.
It helps us figure out what you are trying to
do and what is actually occuring.


OPERATION

A shortcut to start HYDROFLO will be placed
on your Desktop. Click on that icon or click
on the Start-Programs-Tahoe Design Software-
HYDROFLO-HYDROFLO 2 menu item.


NEW FEATURES version 2

Please review the Help file (HF20.chm) or press
the F1 key to view the complete overview of how
to use HYDROFLO 2.0.

HYDROFLO now identifies series pumps and
produces a combined curve on the same plot of
the pumps that produced the combined series curve.

Parallels can now come off of parallels. In the
previous version all parallels were restricted to
come off the main line. The new method enforces
that an element exists in the system at only one
location (unless it is a gauge or supply that
starts a parallel). HYDROFLO will attempt to fix
older multi-parallel designs but you may have
to check them for correctness.

A clipboard in now available that offers off-model
storage of elements. Right-click on elements to
copy or move element from a line to the clipboard
(or use drag and drop). Double-click on elements
in clipboard to edit their basic data. Clipboards
can be saved separately from data files and when
opened, are appended to current clipboard. When a
data file is saved, the current clipboard is saved
with it. To keep the clipboard from getting too
large, delete unneeded elements from it.

IDs are now alphanumeric 15 character strings.
No duplicates are allowed.

If you right-click and "Copy Element" you can then
right-click on an element and "Paste Before" (paste
a copy of the held element to the left of the current
element).

The solution window (when you click the Solve button)
now displays a convergence plot. A good solution
should approach the center line (or zero adjustment
line).

You can now drag and drop elements within lines and
between lines and the clipboard. Hold the Ctrl key
down before dropping and you'll just drop a copy of
the element(s), not moving them. You can drop a group
of selected elements from the clipboard into a line.
Hold the Shift key when selecting another element on
the clipboard and you'll select all the elements
between the two selected or just hold the Ctrl key
down while selecting several elements. When you drag
the group to the line from the clipboard, they will
be dropped top to bottom in the clipboard to left to
right in the line. If you copy elements that would
create duplicate IDs, you'll be prompted to enter a
prefix string so as not to create duplicate IDs.

You can Tag elements. Tagging simply marks the element
with a highlighted frame. This assists the Group Edit
feature described below and allows elements to stand
out.

There is now a group edit feature (right-click on open
space or use Options-Group Edit from main menu). It
allows you to do creative editing on large groups of
elements.

You can now perform "Capture" functions. Click-left
and drag a rectangle (capture area) around a group of
elements in a line and a pop-up menu will offer
various functions such as copy/move to clipboard.

Parallels can now start and/or end at Supply elements.
This allows the solving of independent lines (not true
parallel branches) that do not influence other lines.

PDF files can now be created. When previewing a report,
click on the floppy disk icon to save the report as
a PDF file.
