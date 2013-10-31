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
('David', 'Mokoena', '0791358475', 'david.m@fleet.com', 1),
('Mpho', 'Vilakazi', '0833189847', 'mpho@fleet.com', 2),
('Sarah', 'Watson', '0821456987', 'swatson@gmail.com', 3),
('Goodwill', 'Makathini', '0315589273', 'goodwillm@fleet.com', 4),
('Nthombi', 'Kweyama', '0319961728', 'nkweyama@fleet.com', 5),
('Sipho', 'Matthews', '0715846932', 's.matthews@fleet.com', 6),
('Johnathan', 'Goodall', '0148853957', 'goodall.j@fleet.com', 6),
('Arnold', 'Forfar', '0336529865', 'arnie@gmail.com', 7),
('Sibinelo', 'Thuzi', '0318167193', 'sithuzi@hotmail.com', 7)

insert tblAuth values 
('Office','office', 1),
('Vehicle','vehicle', 2),
('Trip','trip', 3),
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
('NP 128461', '2893465284', 'Mini Bus', '505415', 1, 3, 1),
('GP 543678', '4353525456', 'DHL Truck', '606724', 1, 2, 0),
('GP 239082', '1857934123', 'Spar Truck', '461928', 1, 5, 0),
('WP 645212', '9871235423', 'Cement Truck', '418726', 1, 6, 0),
('GP 897321', '4452134435', '18 Wheeler', '323924', 1, 7, 1),
('GP 324876', '5432215214', 'Abnormal load', '129182',1, 9, 1),
('NP 543287', '1593254123', 'Trailer 1', '321379', 2, 7, 0),
('NP 643123', '3453478237', 'Trailer 2', '322839', 2, 9, 1),
('WP 543251', '6435189879', 'Dump truck', '344123', 1, 6, 0 )

insert tblHours values
(40, 6),
(38, 7),
(42, 8),
(39, 9)

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
('28 October 2013', '110', 4, 'Service Cement mixer'),
('30 October 2013', '122', 3, 'Service brakes')

insert into tblPostTrip values
(1, 162),
(2, 103),
(3, 42),
(4, 15)
