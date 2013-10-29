use OmegaFleetTracker

SELECT tblScheduleTrip.Destination, tblScheduleTrip.DOD[Date Of Departure], tblScheduleTrip.DOA[Date Of Arrival], tblScheduleTrip.Notes[Notes], tblUser.UserFirstName[Employee Name] 
                        FROM tblScheduleTrip, tblUser
                        WHERE tblScheduleTrip.UserID = tblUser.UserID
						 

SELECT tblIncident.Notes, tblVehicle.VehicleReg[Vehicle Registration Number], tblScheduleTrip.DOD[Date Of Departure]
                        FROM tblIncident, tblVehicle, tblScheduleTrip, tblScheduleLine
                        WHERE tblIncident.ScheduleLineID = tblScheduleLine.ScheduleLineID
                        AND tblVehicle.VehicleID = tblScheduleLine.VehicleID
                        AND tblScheduleTrip.TripID = tblScheduleLine.TripID


SELECT tblScheduleTrip.Destination, tblScheduleTrip.DOD[Date Of Departure], tblScheduleTrip.DOA[Date Of Arrival], tblPostTrip.FuelUsage[Fuel Usage]
                        FROM tblScheduleTrip, tblPostTrip
                        WHERE tblPostTrip.TripID = tblScheduleTrip.TripID
						and tblScheduleTrip.DOA < DATEADD(day, DATEDIFF(day,0,GETDATE()),0)

select tblScheduleLine.ScheduleLineID, ('Delivery date: ' + rtrim(tblScheduleTrip.DOD) + ', Vehicle Desc: ' + rtrim(tblVehicle.VehicleDesc) + ', Cargo: ' + rtrim( convert( char(100), tblScheduleTrip.Notes) ) )[Info]
                            from tblScheduleLine, tblScheduleTrip, tblVehicle
                            where tblScheduleLine.TripID  = tblScheduleTrip.TripID
                            and tblScheduleLine.VehicleID = tblVehicle.VehicleID