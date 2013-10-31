use OmegaFleetTracker

insert tblUserType values 
('Office Manager', 'Application user management'),
('Vehicle Information Administrator', 'Maintenance of vehicle record'),
('Trip Manager', 'Scheduling of vehicle trips. Recording fuel usage per trip. Recording incidents per trip'),
('Service Manager', 'Manage appointments scheduling for vechicle service. Prepare daily services job sheet'),
('Timesheet Manager', 'Keeps track of the number of hours worked by drivers and mechanics'),
('Truck Driver', 'Drives trucks'),
('Mechanic', 'Fixes Trucks');

insert tblUser values 
('Bongani', 'Smith', '0821456987', 'Smith@email.com', 1),
('Rebecca', 'Johnson', '0821456987', 'Johnson@email.com', 2),
('Melissa', 'Hart', '0821456987', 'Hart@email.com', 3),
('Mark', 'Torres', '0821456987', 'Torres@email.com', 4),
('John', 'Smith', '0821456987', 'Smith@email.com', 5),
('Dumisane', 'Zuma', '0821456987', 'Zuma@email.com', 6),
('Zanele', 'Nkosi', '0821456987', 'Nkosi@email.com', 6),
('Ben', 'Montgomery', '0821456987', 'Montgomery@email.com', 7),
('Alex', 'Harper', '0821456987', 'Harper@email.com', 7)

insert tblAuth values 
('Office','office', 1),
('Vehicle','vehicle', 2),
('Trip','trip', 3),
('Joe','joe', 3),
('Service','service', 4),
('Timesheet','timesheet', 5)

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
('12345', '12345', 'Mini Bus', '50', 1, 3, 1),
('12345', '12345', 'DHL Truck', '60', 1, 2, 0),
('12345', '12345', 'Spar Truck', '46', 1, 5, 0),
('12345', '12345', 'Cement Truck', '41', 1, 6, 0),
('12345', '12345', '18 Wheeler', '32', 1, 7, 1),
('12345', '12345', 'Abnormal load', '12',1, 9, 1),
('12345', '12345', 'Trailer 1', '32', 2, 7, 0),
('12345', '12345', 'Trailer 2', '32', 2, 9, 1),
('43242', '23432', 'Dump truck', '344123', 1, 6, 0 )

insert tblHours values
(50, 6),
(50, 7),
(50, 8),
(50, 9)

insert into tblScheduleTrip values
('5 November 2013', '12 November 2013', 7, 'Johannesburg', 'Lumber'),
('8 November 2013', '10 November 2013', 6, 'Cape-Town', 'Ammunition'),
('11 November 2013', '12 November 2013', 6, 'Witbank', 'Tires'),
('18 October 2013', '20 October 2013', 7, 'Mooi River', 'Package delivery')

insert into tblScheduleLine values
(5, 1),
(7, 1),
(6, 2),
(8, 2),
(9, 3),
(2, 4)


insert into tblIncident values
('Tire blowout point 12 tire 2, replaced', 2),
('Fuel refill', 1),
('Fuel refill', 5)

insert into tblService values
('29 October 2013', '122', 9, 'Service brakes'),
('28 October 2013', '110', 4, 'Service cement mixer'),
('30 October 2013', '122', 3, 'Service brakes')

insert into tblPostTrip values
(1, 162),
(2, 103),
(3, 42),
(4, 15)