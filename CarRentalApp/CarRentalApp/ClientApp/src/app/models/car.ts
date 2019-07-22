export interface Car {
  licensePlate: string,
  brand: string,
  model: string,
  nrOfDoors: number,
  nrOfSeats: number,
  hasAutomaticGearbox: boolean,
  pricePerDay: number,
}

export interface Rental {
  RentalsId: number,
  RegistrationNumber: string,
  StartDate: Date,
  EndDate: Date,
  InfoUserId: number,
  CityStartId: number,
  CityEndId: number
}
