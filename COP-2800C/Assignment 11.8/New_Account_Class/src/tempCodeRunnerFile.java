Account(String name, int id, double balance){
    this.name = name;
    this.id = id;
    this.balance = balance;
    transactions = new ArrayList<Transaction>();
    setDateCreated();
}