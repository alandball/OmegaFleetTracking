use OmegaFleetTracker

insert tblUserType values 
('Office Manager', 'Application user management'),
('Vehicle information administrator', 'Maintenance of vehicle record'),
('Trip Manager', 'Scheduling of vehicle trips. Recording fuel usage per trip. Recording incidents per trip'),
('Service manager', 'Manage appointments scheduling for vechicle service. Prepare daily services job sheet'),
('Timesheet manager', 'keeps track of the number of hours worked by drivers and mechanics'),
('Truck Driver', 'Drives trucks'),
('Mechanic', 'Fixes Trucks');

insert tblUser values 
('Henry', 'Le Roux', '0821456987', 'henry@email.com', 1)

insert tblAuth values 
('Admin','admin', 1)

insert tblCategory values 
('1A', 'Motorcycle'),
('2B', 'Small vehicle (Cars & Bakkie) - no trailer'),
('3B1', 'Small vehicle (Cars & Bakkie) - trailer'),
('4C', 'Medium vehicle (Spar Truck) - no trailer'),
('5C1', 'Medium vehicle (Spar Truck) - trailer'),
('6D', 'Large vehicle (18 Wheeler & Cement Truck & Reloader) - no trailer'),
('7D1', 'Large vehicle (18 Wheeler & Cement Truck & Reloader) - trailer'),
('8E','Extra large vehicle (Abnormal load) - no trailer'),
('9E1','Extra large vehicle (Abnormal load) - trailer')

insert tblVehicleType values
('Truck'),
('Trailer')

insert tblVehicle values
('12345', '12345', 'Mini Bus', '50', 1, 3),
('12345', '12345', 'DHL Truck', '60', 1, 2),
('12345', '12345', 'Spar Truck', '46', 1, 5),
('12345', '12345', 'Cement Truck', '41', 1, 6),
('12345', '12345', '18 Wheeler', '32', 1, 7),
('12345', '12345', 'Abnormal load', '12',1, 9),
('12345', '12345', 'Trailer 1', '32', 2, 7),
('12345', '12345', 'Trailer 2', '32', 2, 9)