﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2023 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using QuantConnect.CoinbaseBrokerage.Models.Enums;

namespace QuantConnect.CoinbaseBrokerage.Models.WebSocket;

public class CoinbaseMarketTradesEvent : WebSocketEvent
{
    [JsonProperty("trades")]
    public List<Trade> Trades { get; set; } = new List<Trade>();
}

public class Trade
{
    [JsonProperty("trade_id")]
    public long TradeId { get; set; }

    [JsonProperty("product_id")]
    public string ProductId { get; set; }

    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("size")]
    public decimal? Size { get; set; }

    [JsonProperty("side")]
    public OrderSide Side { get; set; }

    [JsonProperty("time")]
    public DateTimeOffset Time { get; set; }
}
