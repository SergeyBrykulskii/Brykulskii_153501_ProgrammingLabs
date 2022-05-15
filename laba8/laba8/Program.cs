using laba8;

Hotel testHotel = new Hotel();

testHotel.AddAbsDiscountRoom(2, 100, 10);
testHotel.AddNoDiscountRoom(3, 100);

Console.WriteLine(testHotel.GetTotalPrice());

