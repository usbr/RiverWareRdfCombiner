# RiverWareRdfCombiner
C# program in .Net 4.0 to combine multiple RiverWare RDF files.

This program combines two RiverWare RDF files. Data from the selected RDF-2 is appended to the selected RDF-1. The run name, owner, description, and create data fields from RDF-1 is preserved and the number of runs is incremented by the number of runs in RDF-2. Clicking on Combine will prompt you to choose a name and directory in which to create the new RDF file.

It is important to note that most software libraries that read RiverWare MRM RDFs assume that all entries within an RDF have constant run dates and time steps. Combining RDFs that have different run dates and time steps will result in improper processing by these software.

This program is distributed with an MIT license.
