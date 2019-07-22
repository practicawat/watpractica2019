export class SearchedCar {

  constructor(
   public selectedCity: string,
   public selectedPickupHour: string,
   public selectedReturnHour: string,
   public selectedPickupPeriod: string,
   public selectedReturnPeriod: string,
   public concatenatePickup: string,
   public concatenateReturn: string,
   public isChecked: boolean,
  ) {

  }

}
