---- User table
--CREATE TABLE User_ (
--    user_id INT PRIMARY KEY,
--    username VARCHAR(50) UNIQUE NOT NULL,
--    password VARCHAR(50) NOT NULL,
--    email VARCHAR(100) UNIQUE NOT NULL,
--    first_name VARCHAR(50) NOT NULL,
--    last_name VARCHAR(50) NOT NULL
--);

---- Stock table
--CREATE TABLE Stock (
--    stock_id INT PRIMARY KEY,
--    name VARCHAR(50) NOT NULL,
--    symbol VARCHAR(10) UNIQUE NOT NULL
--);

---- Price table
--CREATE TABLE Price (
--    price_id INT PRIMARY KEY,
--    stock_id INT NOT NULL,
--    date DATE NOT NULL,
--    open_price DECIMAL(10,2) NOT NULL,
--    close_price DECIMAL(10,2) NOT NULL,
--    high_price DECIMAL(10,2) NOT NULL,
--    low_price DECIMAL(10,2) NOT NULL,
--    volume INT NOT NULL,
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id)
--);

---- Portfolio table
--CREATE TABLE Portfolio (
--    portfolio_id INT PRIMARY KEY,
--    user_id INT NOT NULL,
--    name VARCHAR(50) NOT NULL,
--    description VARCHAR(255),
--    FOREIGN KEY (user_id) REFERENCES User_(user_id)
--);

---- PortfolioStock table
--CREATE TABLE PortfolioStock (
--    portfolio_stock_id INT PRIMARY KEY,
--    portfolio_id INT NOT NULL,
--    stock_id INT NOT NULL,
--    FOREIGN KEY (portfolio_id) REFERENCES Portfolio(portfolio_id),
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id)
--);

---- Trade table
--CREATE TABLE Trade (
--    trade_id INT PRIMARY KEY,
--    user_id INT NOT NULL,
--    stock_id INT NOT NULL,
--    date DATE NOT NULL,
--    buy_sell VARCHAR(10) NOT NULL,
--    price DECIMAL(10,2) NOT NULL,
--    quantity INT NOT NULL,
--    FOREIGN KEY (user_id) REFERENCES User_(user_id),
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id)
--);

---- News table
--CREATE TABLE News (
--    news_id INT PRIMARY KEY,
--    stock_id INT NOT NULL,
--    headline VARCHAR(255) NOT NULL,
--    summary VARCHAR(255),
--    date DATE NOT NULL,
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id)
--);

---- Sector table
--CREATE TABLE Sector (
--    sector_id INT PRIMARY KEY,
--    name VARCHAR(50) NOT NULL
--);

---- StockSector table
--CREATE TABLE StockSector (
--    stock_sector_id INT PRIMARY KEY,
--    stock_id INT NOT NULL,
--    sector_id INT NOT NULL,
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id),
--    FOREIGN KEY (sector_id) REFERENCES Sector(sector_id)
--);

---- Exchange table
--CREATE TABLE Exchange (
--    exchange_id INT PRIMARY KEY,
--    name VARCHAR(50) NOT NULL
--);

---- StockExchange table
--CREATE TABLE StockExchange (
--    stock_exchange_id INT PRIMARY KEY,
--    stock_id INT NOT NULL,
--    exchange_id INT NOT NULL,
--    FOREIGN KEY (stock_id) REFERENCES Stock(stock_id),
--    FOREIGN KEY (exchange_id) REFERENCES Exchange(exchange_id)
--);


--INSERT INTO User_ (user_id, username, password, email, first_name, last_name) VALUES
--  (1, 'johndoe', 'password123', 'johndoe@example.com', 'John', 'Doe'),
--  (2, 'janesmith', 'password456', 'janesmith@example.com', 'Jane', 'Smith'),
--  (3, 'bobsmith', 'password789', 'bobsmith@example.com', 'Bob', 'Smith'),
--  (4, 'sarahjones', 'password321', 'sarahjones@example.com', 'Sarah', 'Jones'),
--  (5, 'samuelwang', 'password654', 'samuelwang@example.com', 'Samuel', 'Wang'),
--  (6, 'juliesmith', 'password987', 'juliesmith@example.com', 'Julie', 'Smith'),
--  (7, 'michaelscott', 'password246', 'michaelscott@example.com', 'Michael', 'Scott'),
--  (8, 'pamelasmith', 'password135', 'pamelasmith@example.com', 'Pamela', 'Smith'),
--  (9, 'williamjones', 'password579', 'williamjones@example.com', 'William', 'Jones'),
--  (10, 'christopherlee', 'password864', 'christopherlee@example.com', 'Christopher', 'Lee');

---- Stock table inserts
--INSERT INTO Stock (stock_id, name, symbol) VALUES
--  (1, 'Apple Inc.', 'AAPL'),
--  (2, 'Amazon.com Inc.', 'AMZN'),
--  (3, 'Microsoft Corporation', 'MSFT'),
--  (4, 'Alphabet Inc. Class A', 'GOOGL'),
--  (5, 'Facebook Inc. Class A', 'FB'),
--  (6, 'Tesla Inc.', 'TSLA'),
--  (7, 'NVIDIA Corporation', 'NVDA'),
--  (8, 'PayPal Holdings Inc.', 'PYPL'),
--  (9, 'Netflix Inc.', 'NFLX'),
--  (10, 'Visa Inc. Class A', 'V');

--INSERT INTO Price (price_id, stock_id, date, open_price, close_price, high_price, low_price, volume) VALUES
--  (1, 1, '2022-03-10', 178.91, 181.02, 183.12, 177.74, 62104054),
--  (2, 2, '2022-03-10', 3078.97, 3089.89, 3097.60, 3047.15, 2215174),
--  (3, 3, '2022-03-10', 310.06, 311.53, 313.15, 308.27, 36131194),
--  (4, 4, '2022-03-10', 2364.94, 2372.21, 2378.59, 2349.78, 1185143),
--  (5, 5, '2022-03-10', 304.67, 306.63, 309.00, 302.40, 10796895),
--  (6, 6, '2022-03-10', 907.87, 912.88, 921.42, 902.00, 13417287),
--  (7, 7, '2022-03-10', 305.27, 308.64, 309.57, 303.73, 13897415),
--  (8, 8, '2022-03-10', 261.00, 262.87, 263.89, 258.77, 5164512),
--  (9, 9, '2022-03-10', 600.09, 602.41, 604.99, 596.87, 1861618),
--  (10, 10, '2022-03-10', 231.79, 233.62, 234.69, 230.39, 8494375);

---- Portfolio table inserts
--INSERT INTO Portfolio (portfolio_id, user_id, name) VALUES
--  (1, 1, 'Tech Stocks'),
--  (2, 2, 'Energy Stocks'),
--  (3, 3, 'Retail Stocks'),
--  (4, 4, 'Pharma Stocks'),
--  (5, 5, 'Dividend Stocks'),
--  (6, 6, 'Growth Stocks'),
--  (7, 7, 'Value Stocks'),
--  (8, 8, 'Index Funds'),
--  (9, 9, 'Bond Funds'),
--  (10, 10, 'Cryptocurrency');

--INSERT INTO PortfolioStock (portfolio_stock_id, portfolio_id, stock_id) VALUES
--  (1, 1, 1),
--  (2, 1, 2),
--  (3, 1, 3),
--  (4, 2, 4),
--  (5, 2, 5),
--  (6, 2, 6),
--  (7, 3, 7),
--  (8, 3, 8),
--  (9, 3, 9),
--  (10, 4, 1),
--  (11, 4, 4),
--  (12, 4, 6),
--  (13, 5, 2),
--  (14, 5, 5),
--  (15, 5, 8),
--  (16, 6, 3),
--  (17, 6, 4),
--  (18, 6, 6),
--  (19, 7, 1),
--  (20, 7, 5),
--  (21, 7, 7),
--  (22, 8, 2),
--  (23, 8, 5),
--  (24, 8, 8),
--  (25, 9, 3),
--  (26, 9, 6),
--  (27, 9, 9),
--  (28, 10, 10);


--  INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (1, 1, 2, '2022-01-05', 'buy', 50.00, 100);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (2, 1, 3, '2022-01-07', 'sell', 25.00, 50);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (3, 2, 1, '2022-02-01', 'buy', 75.00, 200);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (4, 2, 4, '2022-02-10', 'sell', 100.00, 150);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (5, 1, 5, '2022-03-15', 'buy', 10.00, 500);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (6, 2, 3, '2022-03-20', 'sell', 30.00, 100);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (7, 1, 2, '2022-04-05', 'buy', 55.00, 75);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (8, 1, 4, '2022-05-01', 'sell', 90.00, 100);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (9, 2, 6, '2022-05-15', 'buy', 15.00, 200);
--INSERT INTO Trade (trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES (10, 1, 7, '2022-06-01', 'sell', 75.00, 50);

--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (1, 1, 'Tech giant releases new smartphone model', 'Tech giant XYZ has announced the release of their latest smartphone model, which features an improved camera and longer battery life.', '2022-01-01');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (2, 1, 'Analysts predict strong earnings for tech company', 'Analysts are predicting strong earnings for tech company XYZ, citing increased demand for their products and services.', '2022-02-15');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (3, 2, 'New drug approved by FDA', 'Pharmaceutical company ABC has received approval from the FDA for their latest drug, which is designed to treat a rare genetic disorder.', '2022-03-10');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (4, 2, 'Company expands into new market', 'Pharmaceutical company ABC has announced plans to expand into a new market, which is expected to drive growth and revenue.', '2022-04-20');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (5, 3, 'Oil prices surge amid tensions in the Middle East', 'Oil prices have surged following tensions in the Middle East, with experts predicting that prices will continue to rise.', '2022-05-05');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (6, 3, 'Oil company reports strong quarterly earnings', 'Oil company XYZ has reported strong quarterly earnings, thanks in part to rising oil prices.', '2022-06-30');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (7, 4, 'New regulations expected to impact industry', 'Industry experts are predicting that new regulations could have a significant impact on companies in the sector, including company XYZ.', '2022-07-15');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (8, 4, 'Company announces plans to expand into new market', 'Company XYZ has announced plans to expand into a new market, which is expected to drive growth and revenue.', '2022-08-25');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (9, 5, 'Tech startup raises $10 million in funding', 'Tech startup ABC has raised $10 million in funding from investors, which will be used to develop new products and expand operations.', '2022-09-10');
--INSERT INTO News (news_id, stock_id, headline, summary, date) VALUES (10, 5, 'CEO announces plans to step down', 'CEO of tech startup ABC has announced plans to step down from their position, citing personal reasons.', '2022-10-20');

--INSERT INTO Sector (sector_id, name) VALUES (1, 'Technology');
--INSERT INTO Sector (sector_id, name) VALUES (2, 'Healthcare');
--INSERT INTO Sector (sector_id, name) VALUES (3, 'Consumer Goods');
--INSERT INTO Sector (sector_id, name) VALUES (4, 'Finance');
--INSERT INTO Sector (sector_id, name) VALUES (5, 'Utilities');
--INSERT INTO Sector (sector_id, name) VALUES (6, 'Industrials');
--INSERT INTO Sector (sector_id, name) VALUES (7, 'Energy');
--INSERT INTO Sector (sector_id, name) VALUES (8, 'Basic Materials');
--INSERT INTO Sector (sector_id, name) VALUES (9, 'Telecommunications');
--INSERT INTO Sector (sector_id, name) VALUES (10, 'Real Estate');

--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (1, 1, 2);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (2, 1, 4);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (3, 2, 1);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (4, 2, 3);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (5, 3, 5);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (6, 3, 1);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (7, 4, 2);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (8, 4, 3);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (9, 5, 1);
--INSERT INTO StockSector (stock_sector_id, stock_id, sector_id) VALUES (10, 5, 2);

--INSERT INTO Exchange (exchange_id, name) VALUES (1, 'New York Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (2, 'NASDAQ');
--INSERT INTO Exchange (exchange_id, name) VALUES (3, 'London Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (4, 'Tokyo Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (5, 'Shanghai Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (6, 'Hong Kong Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (7, 'Toronto Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (8, 'Euronext');
--INSERT INTO Exchange (exchange_id, name) VALUES (9, 'Frankfurt Stock Exchange');
--INSERT INTO Exchange (exchange_id, name) VALUES (10, 'Australian Securities Exchange');


--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (1, 1, 1);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (2, 1, 2);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (3, 2, 1);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (4, 3, 2);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (5, 4, 1);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (6, 4, 2);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (7, 5, 2);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (8, 6, 1);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (9, 7, 2);
--INSERT INTO StockExchange (stock_exchange_id, stock_id, exchange_id) VALUES (10, 8, 1);


