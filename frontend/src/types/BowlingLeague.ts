export type BowlingLeague = {
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: number;
  teamName: string;
};

export type Team = {
  teamId: number;
  teamName: string;
  captainId: number;
};
