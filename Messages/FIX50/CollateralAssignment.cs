// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50
    {
        public class CollateralAssignment : Message
        {
            public const string MsgType = "AY";

            public CollateralAssignment() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AY"));
            }

            public CollateralAssignment(
                    QuickFix.Fields.CollAsgnID aCollAsgnID,
                    QuickFix.Fields.CollAsgnReason aCollAsgnReason,
                    QuickFix.Fields.CollAsgnTransType aCollAsgnTransType,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.CollAsgnID = aCollAsgnID;
                this.CollAsgnReason = aCollAsgnReason;
                this.CollAsgnTransType = aCollAsgnTransType;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.Fields.CollAsgnID CollAsgnID
            {
                get
                {
                    QuickFix.Fields.CollAsgnID val = new QuickFix.Fields.CollAsgnID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CollAsgnID val)
            {
                this.CollAsgnID = val;
            }

            public QuickFix.Fields.CollAsgnID Get(QuickFix.Fields.CollAsgnID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CollAsgnID val)
            {
                return IsSetCollAsgnID();
            }

            public bool IsSetCollAsgnID()
            {
                return IsSetField(Tags.CollAsgnID);
            }

            public QuickFix.Fields.CollReqID CollReqID
            {
                get
                {
                    QuickFix.Fields.CollReqID val = new QuickFix.Fields.CollReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CollReqID val)
            {
                this.CollReqID = val;
            }

            public QuickFix.Fields.CollReqID Get(QuickFix.Fields.CollReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CollReqID val)
            {
                return IsSetCollReqID();
            }

            public bool IsSetCollReqID()
            {
                return IsSetField(Tags.CollReqID);
            }

            public QuickFix.Fields.CollAsgnReason CollAsgnReason
            {
                get
                {
                    QuickFix.Fields.CollAsgnReason val = new QuickFix.Fields.CollAsgnReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CollAsgnReason val)
            {
                this.CollAsgnReason = val;
            }

            public QuickFix.Fields.CollAsgnReason Get(QuickFix.Fields.CollAsgnReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CollAsgnReason val)
            {
                return IsSetCollAsgnReason();
            }

            public bool IsSetCollAsgnReason()
            {
                return IsSetField(Tags.CollAsgnReason);
            }

            public QuickFix.Fields.CollAsgnTransType CollAsgnTransType
            {
                get
                {
                    QuickFix.Fields.CollAsgnTransType val = new QuickFix.Fields.CollAsgnTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CollAsgnTransType val)
            {
                this.CollAsgnTransType = val;
            }

            public QuickFix.Fields.CollAsgnTransType Get(QuickFix.Fields.CollAsgnTransType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CollAsgnTransType val)
            {
                return IsSetCollAsgnTransType();
            }

            public bool IsSetCollAsgnTransType()
            {
                return IsSetField(Tags.CollAsgnTransType);
            }

            public QuickFix.Fields.CollAsgnRefID CollAsgnRefID
            {
                get
                {
                    QuickFix.Fields.CollAsgnRefID val = new QuickFix.Fields.CollAsgnRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CollAsgnRefID val)
            {
                this.CollAsgnRefID = val;
            }

            public QuickFix.Fields.CollAsgnRefID Get(QuickFix.Fields.CollAsgnRefID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CollAsgnRefID val)
            {
                return IsSetCollAsgnRefID();
            }

            public bool IsSetCollAsgnRefID()
            {
                return IsSetField(Tags.CollAsgnRefID);
            }

            public QuickFix.Fields.TransactTime TransactTime
            {
                get
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransactTime val)
            {
                this.TransactTime = val;
            }

            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransactTime val)
            {
                return IsSetTransactTime();
            }

            public bool IsSetTransactTime()
            {
                return IsSetField(Tags.TransactTime);
            }

            public QuickFix.Fields.ExpireTime ExpireTime
            {
                get
                {
                    QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ExpireTime val)
            {
                this.ExpireTime = val;
            }

            public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ExpireTime val)
            {
                return IsSetExpireTime();
            }

            public bool IsSetExpireTime()
            {
                return IsSetField(Tags.ExpireTime);
            }

            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyIDs val)
            {
                this.NoPartyIDs = val;
            }

            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyIDs val)
            {
                return IsSetNoPartyIDs();
            }

            public bool IsSetNoPartyIDs()
            {
                return IsSetField(Tags.NoPartyIDs);
            }

            public QuickFix.Fields.Account Account
            {
                get
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Account val)
            {
                this.Account = val;
            }

            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Account val)
            {
                return IsSetAccount();
            }

            public bool IsSetAccount()
            {
                return IsSetField(Tags.Account);
            }

            public QuickFix.Fields.AccountType AccountType
            {
                get
                {
                    QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AccountType val)
            {
                this.AccountType = val;
            }

            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AccountType val)
            {
                return IsSetAccountType();
            }

            public bool IsSetAccountType()
            {
                return IsSetField(Tags.AccountType);
            }

            public QuickFix.Fields.ClOrdID ClOrdID
            {
                get
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClOrdID val)
            {
                this.ClOrdID = val;
            }

            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClOrdID val)
            {
                return IsSetClOrdID();
            }

            public bool IsSetClOrdID()
            {
                return IsSetField(Tags.ClOrdID);
            }

            public QuickFix.Fields.OrderID OrderID
            {
                get
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrderID val)
            {
                this.OrderID = val;
            }

            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrderID val)
            {
                return IsSetOrderID();
            }

            public bool IsSetOrderID()
            {
                return IsSetField(Tags.OrderID);
            }

            public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
            {
                get
                {
                    QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecondaryOrderID val)
            {
                this.SecondaryOrderID = val;
            }

            public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecondaryOrderID val)
            {
                return IsSetSecondaryOrderID();
            }

            public bool IsSetSecondaryOrderID()
            {
                return IsSetField(Tags.SecondaryOrderID);
            }

            public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
            {
                get
                {
                    QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecondaryClOrdID val)
            {
                this.SecondaryClOrdID = val;
            }

            public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecondaryClOrdID val)
            {
                return IsSetSecondaryClOrdID();
            }

            public bool IsSetSecondaryClOrdID()
            {
                return IsSetField(Tags.SecondaryClOrdID);
            }

            public QuickFix.Fields.NoExecs NoExecs
            {
                get
                {
                    QuickFix.Fields.NoExecs val = new QuickFix.Fields.NoExecs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoExecs val)
            {
                this.NoExecs = val;
            }

            public QuickFix.Fields.NoExecs Get(QuickFix.Fields.NoExecs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoExecs val)
            {
                return IsSetNoExecs();
            }

            public bool IsSetNoExecs()
            {
                return IsSetField(Tags.NoExecs);
            }

            public QuickFix.Fields.NoTrades NoTrades
            {
                get
                {
                    QuickFix.Fields.NoTrades val = new QuickFix.Fields.NoTrades();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoTrades val)
            {
                this.NoTrades = val;
            }

            public QuickFix.Fields.NoTrades Get(QuickFix.Fields.NoTrades val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoTrades val)
            {
                return IsSetNoTrades();
            }

            public bool IsSetNoTrades()
            {
                return IsSetField(Tags.NoTrades);
            }

            public QuickFix.Fields.Symbol Symbol
            {
                get
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Symbol val)
            {
                this.Symbol = val;
            }

            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Symbol val)
            {
                return IsSetSymbol();
            }

            public bool IsSetSymbol()
            {
                return IsSetField(Tags.Symbol);
            }

            public QuickFix.Fields.SymbolSfx SymbolSfx
            {
                get
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SymbolSfx val)
            {
                this.SymbolSfx = val;
            }

            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SymbolSfx val)
            {
                return IsSetSymbolSfx();
            }

            public bool IsSetSymbolSfx()
            {
                return IsSetField(Tags.SymbolSfx);
            }

            public QuickFix.Fields.SecurityID SecurityID
            {
                get
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityID val)
            {
                this.SecurityID = val;
            }

            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityID val)
            {
                return IsSetSecurityID();
            }

            public bool IsSetSecurityID()
            {
                return IsSetField(Tags.SecurityID);
            }

            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            {
                get
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityIDSource val)
            {
                this.SecurityIDSource = val;
            }

            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityIDSource val)
            {
                return IsSetSecurityIDSource();
            }

            public bool IsSetSecurityIDSource()
            {
                return IsSetField(Tags.SecurityIDSource);
            }

            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            {
                get
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoSecurityAltID val)
            {
                this.NoSecurityAltID = val;
            }

            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoSecurityAltID val)
            {
                return IsSetNoSecurityAltID();
            }

            public bool IsSetNoSecurityAltID()
            {
                return IsSetField(Tags.NoSecurityAltID);
            }

            public QuickFix.Fields.Product Product
            {
                get
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Product val)
            {
                this.Product = val;
            }

            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Product val)
            {
                return IsSetProduct();
            }

            public bool IsSetProduct()
            {
                return IsSetField(Tags.Product);
            }

            public QuickFix.Fields.CFICode CFICode
            {
                get
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CFICode val)
            {
                this.CFICode = val;
            }

            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CFICode val)
            {
                return IsSetCFICode();
            }

            public bool IsSetCFICode()
            {
                return IsSetField(Tags.CFICode);
            }

            public QuickFix.Fields.SecurityType SecurityType
            {
                get
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityType val)
            {
                this.SecurityType = val;
            }

            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityType val)
            {
                return IsSetSecurityType();
            }

            public bool IsSetSecurityType()
            {
                return IsSetField(Tags.SecurityType);
            }

            public QuickFix.Fields.SecuritySubType SecuritySubType
            {
                get
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecuritySubType val)
            {
                this.SecuritySubType = val;
            }

            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecuritySubType val)
            {
                return IsSetSecuritySubType();
            }

            public bool IsSetSecuritySubType()
            {
                return IsSetField(Tags.SecuritySubType);
            }

            public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
            {
                get
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityMonthYear val)
            {
                this.MaturityMonthYear = val;
            }

            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityMonthYear val)
            {
                return IsSetMaturityMonthYear();
            }

            public bool IsSetMaturityMonthYear()
            {
                return IsSetField(Tags.MaturityMonthYear);
            }

            public QuickFix.Fields.MaturityDate MaturityDate
            {
                get
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityDate val)
            {
                this.MaturityDate = val;
            }

            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityDate val)
            {
                return IsSetMaturityDate();
            }

            public bool IsSetMaturityDate()
            {
                return IsSetField(Tags.MaturityDate);
            }

            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            {
                get
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CouponPaymentDate val)
            {
                this.CouponPaymentDate = val;
            }

            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CouponPaymentDate val)
            {
                return IsSetCouponPaymentDate();
            }

            public bool IsSetCouponPaymentDate()
            {
                return IsSetField(Tags.CouponPaymentDate);
            }

            public QuickFix.Fields.IssueDate IssueDate
            {
                get
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.IssueDate val)
            {
                this.IssueDate = val;
            }

            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.IssueDate val)
            {
                return IsSetIssueDate();
            }

            public bool IsSetIssueDate()
            {
                return IsSetField(Tags.IssueDate);
            }

            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            {
                get
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                this.RepoCollateralSecurityType = val;
            }

            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                return IsSetRepoCollateralSecurityType();
            }

            public bool IsSetRepoCollateralSecurityType()
            {
                return IsSetField(Tags.RepoCollateralSecurityType);
            }

            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            {
                get
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepurchaseTerm val)
            {
                this.RepurchaseTerm = val;
            }

            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepurchaseTerm val)
            {
                return IsSetRepurchaseTerm();
            }

            public bool IsSetRepurchaseTerm()
            {
                return IsSetField(Tags.RepurchaseTerm);
            }

            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            {
                get
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepurchaseRate val)
            {
                this.RepurchaseRate = val;
            }

            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepurchaseRate val)
            {
                return IsSetRepurchaseRate();
            }

            public bool IsSetRepurchaseRate()
            {
                return IsSetField(Tags.RepurchaseRate);
            }

            public QuickFix.Fields.Factor Factor
            {
                get
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Factor val)
            {
                this.Factor = val;
            }

            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Factor val)
            {
                return IsSetFactor();
            }

            public bool IsSetFactor()
            {
                return IsSetField(Tags.Factor);
            }

            public QuickFix.Fields.CreditRating CreditRating
            {
                get
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CreditRating val)
            {
                this.CreditRating = val;
            }

            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CreditRating val)
            {
                return IsSetCreditRating();
            }

            public bool IsSetCreditRating()
            {
                return IsSetField(Tags.CreditRating);
            }

            public QuickFix.Fields.InstrRegistry InstrRegistry
            {
                get
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrRegistry val)
            {
                this.InstrRegistry = val;
            }

            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrRegistry val)
            {
                return IsSetInstrRegistry();
            }

            public bool IsSetInstrRegistry()
            {
                return IsSetField(Tags.InstrRegistry);
            }

            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            {
                get
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CountryOfIssue val)
            {
                this.CountryOfIssue = val;
            }

            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CountryOfIssue val)
            {
                return IsSetCountryOfIssue();
            }

            public bool IsSetCountryOfIssue()
            {
                return IsSetField(Tags.CountryOfIssue);
            }

            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            {
                get
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                this.StateOrProvinceOfIssue = val;
            }

            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                return IsSetStateOrProvinceOfIssue();
            }

            public bool IsSetStateOrProvinceOfIssue()
            {
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }

            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            {
                get
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LocaleOfIssue val)
            {
                this.LocaleOfIssue = val;
            }

            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LocaleOfIssue val)
            {
                return IsSetLocaleOfIssue();
            }

            public bool IsSetLocaleOfIssue()
            {
                return IsSetField(Tags.LocaleOfIssue);
            }

            public QuickFix.Fields.RedemptionDate RedemptionDate
            {
                get
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RedemptionDate val)
            {
                this.RedemptionDate = val;
            }

            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RedemptionDate val)
            {
                return IsSetRedemptionDate();
            }

            public bool IsSetRedemptionDate()
            {
                return IsSetField(Tags.RedemptionDate);
            }

            public QuickFix.Fields.StrikePrice StrikePrice
            {
                get
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StrikePrice val)
            {
                this.StrikePrice = val;
            }

            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StrikePrice val)
            {
                return IsSetStrikePrice();
            }

            public bool IsSetStrikePrice()
            {
                return IsSetField(Tags.StrikePrice);
            }

            public QuickFix.Fields.StrikeCurrency StrikeCurrency
            {
                get
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StrikeCurrency val)
            {
                this.StrikeCurrency = val;
            }

            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StrikeCurrency val)
            {
                return IsSetStrikeCurrency();
            }

            public bool IsSetStrikeCurrency()
            {
                return IsSetField(Tags.StrikeCurrency);
            }

            public QuickFix.Fields.OptAttribute OptAttribute
            {
                get
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OptAttribute val)
            {
                this.OptAttribute = val;
            }

            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OptAttribute val)
            {
                return IsSetOptAttribute();
            }

            public bool IsSetOptAttribute()
            {
                return IsSetField(Tags.OptAttribute);
            }

            public QuickFix.Fields.ContractMultiplier ContractMultiplier
            {
                get
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ContractMultiplier val)
            {
                this.ContractMultiplier = val;
            }

            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ContractMultiplier val)
            {
                return IsSetContractMultiplier();
            }

            public bool IsSetContractMultiplier()
            {
                return IsSetField(Tags.ContractMultiplier);
            }

            public QuickFix.Fields.CouponRate CouponRate
            {
                get
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CouponRate val)
            {
                this.CouponRate = val;
            }

            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CouponRate val)
            {
                return IsSetCouponRate();
            }

            public bool IsSetCouponRate()
            {
                return IsSetField(Tags.CouponRate);
            }

            public QuickFix.Fields.SecurityExchange SecurityExchange
            {
                get
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityExchange val)
            {
                this.SecurityExchange = val;
            }

            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityExchange val)
            {
                return IsSetSecurityExchange();
            }

            public bool IsSetSecurityExchange()
            {
                return IsSetField(Tags.SecurityExchange);
            }

            public QuickFix.Fields.Issuer Issuer
            {
                get
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Issuer val)
            {
                this.Issuer = val;
            }

            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Issuer val)
            {
                return IsSetIssuer();
            }

            public bool IsSetIssuer()
            {
                return IsSetField(Tags.Issuer);
            }

            public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
            {
                get
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedIssuerLen val)
            {
                this.EncodedIssuerLen = val;
            }

            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val)
            {
                return IsSetEncodedIssuerLen();
            }

            public bool IsSetEncodedIssuerLen()
            {
                return IsSetField(Tags.EncodedIssuerLen);
            }

            public QuickFix.Fields.EncodedIssuer EncodedIssuer
            {
                get
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedIssuer val)
            {
                this.EncodedIssuer = val;
            }

            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedIssuer val)
            {
                return IsSetEncodedIssuer();
            }

            public bool IsSetEncodedIssuer()
            {
                return IsSetField(Tags.EncodedIssuer);
            }

            public QuickFix.Fields.SecurityDesc SecurityDesc
            {
                get
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityDesc val)
            {
                this.SecurityDesc = val;
            }

            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityDesc val)
            {
                return IsSetSecurityDesc();
            }

            public bool IsSetSecurityDesc()
            {
                return IsSetField(Tags.SecurityDesc);
            }

            public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            {
                get
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                this.EncodedSecurityDescLen = val;
            }

            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                return IsSetEncodedSecurityDescLen();
            }

            public bool IsSetEncodedSecurityDescLen()
            {
                return IsSetField(Tags.EncodedSecurityDescLen);
            }

            public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
            {
                get
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedSecurityDesc val)
            {
                this.EncodedSecurityDesc = val;
            }

            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val)
            {
                return IsSetEncodedSecurityDesc();
            }

            public bool IsSetEncodedSecurityDesc()
            {
                return IsSetField(Tags.EncodedSecurityDesc);
            }

            public QuickFix.Fields.Pool Pool
            {
                get
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Pool val)
            {
                this.Pool = val;
            }

            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Pool val)
            {
                return IsSetPool();
            }

            public bool IsSetPool()
            {
                return IsSetField(Tags.Pool);
            }

            public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
            {
                get
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ContractSettlMonth val)
            {
                this.ContractSettlMonth = val;
            }

            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ContractSettlMonth val)
            {
                return IsSetContractSettlMonth();
            }

            public bool IsSetContractSettlMonth()
            {
                return IsSetField(Tags.ContractSettlMonth);
            }

            public QuickFix.Fields.CPProgram CPProgram
            {
                get
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CPProgram val)
            {
                this.CPProgram = val;
            }

            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CPProgram val)
            {
                return IsSetCPProgram();
            }

            public bool IsSetCPProgram()
            {
                return IsSetField(Tags.CPProgram);
            }

            public QuickFix.Fields.CPRegType CPRegType
            {
                get
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CPRegType val)
            {
                this.CPRegType = val;
            }

            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CPRegType val)
            {
                return IsSetCPRegType();
            }

            public bool IsSetCPRegType()
            {
                return IsSetField(Tags.CPRegType);
            }

            public QuickFix.Fields.NoEvents NoEvents
            {
                get
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoEvents val)
            {
                this.NoEvents = val;
            }

            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoEvents val)
            {
                return IsSetNoEvents();
            }

            public bool IsSetNoEvents()
            {
                return IsSetField(Tags.NoEvents);
            }

            public QuickFix.Fields.DatedDate DatedDate
            {
                get
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.DatedDate val)
            {
                this.DatedDate = val;
            }

            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.DatedDate val)
            {
                return IsSetDatedDate();
            }

            public bool IsSetDatedDate()
            {
                return IsSetField(Tags.DatedDate);
            }

            public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
            {
                get
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InterestAccrualDate val)
            {
                this.InterestAccrualDate = val;
            }

            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InterestAccrualDate val)
            {
                return IsSetInterestAccrualDate();
            }

            public bool IsSetInterestAccrualDate()
            {
                return IsSetField(Tags.InterestAccrualDate);
            }

            public QuickFix.Fields.SecurityStat SecurityStat
            {
                get
                {
                    QuickFix.Fields.SecurityStat val = new QuickFix.Fields.SecurityStat();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityStat val)
            {
                this.SecurityStat = val;
            }

            public QuickFix.Fields.SecurityStat Get(QuickFix.Fields.SecurityStat val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityStat val)
            {
                return IsSetSecurityStat();
            }

            public bool IsSetSecurityStat()
            {
                return IsSetField(Tags.SecurityStat);
            }

            public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
            {
                get
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettleOnOpenFlag val)
            {
                this.SettleOnOpenFlag = val;
            }

            public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val)
            {
                return IsSetSettleOnOpenFlag();
            }

            public bool IsSetSettleOnOpenFlag()
            {
                return IsSetField(Tags.SettleOnOpenFlag);
            }

            public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
            {
                get
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrmtAssignmentMethod val)
            {
                this.InstrmtAssignmentMethod = val;
            }

            public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val)
            {
                return IsSetInstrmtAssignmentMethod();
            }

            public bool IsSetInstrmtAssignmentMethod()
            {
                return IsSetField(Tags.InstrmtAssignmentMethod);
            }

            public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
            {
                get
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StrikeMultiplier val)
            {
                this.StrikeMultiplier = val;
            }

            public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StrikeMultiplier val)
            {
                return IsSetStrikeMultiplier();
            }

            public bool IsSetStrikeMultiplier()
            {
                return IsSetField(Tags.StrikeMultiplier);
            }

            public QuickFix.Fields.StrikeValue StrikeValue
            {
                get
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StrikeValue val)
            {
                this.StrikeValue = val;
            }

            public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StrikeValue val)
            {
                return IsSetStrikeValue();
            }

            public bool IsSetStrikeValue()
            {
                return IsSetField(Tags.StrikeValue);
            }

            public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
            {
                get
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MinPriceIncrement val)
            {
                this.MinPriceIncrement = val;
            }

            public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MinPriceIncrement val)
            {
                return IsSetMinPriceIncrement();
            }

            public bool IsSetMinPriceIncrement()
            {
                return IsSetField(Tags.MinPriceIncrement);
            }

            public QuickFix.Fields.PositionLimit PositionLimit
            {
                get
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PositionLimit val)
            {
                this.PositionLimit = val;
            }

            public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PositionLimit val)
            {
                return IsSetPositionLimit();
            }

            public bool IsSetPositionLimit()
            {
                return IsSetField(Tags.PositionLimit);
            }

            public QuickFix.Fields.NTPositionLimit NTPositionLimit
            {
                get
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NTPositionLimit val)
            {
                this.NTPositionLimit = val;
            }

            public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NTPositionLimit val)
            {
                return IsSetNTPositionLimit();
            }

            public bool IsSetNTPositionLimit()
            {
                return IsSetField(Tags.NTPositionLimit);
            }

            public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
            {
                get
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoInstrumentParties val)
            {
                this.NoInstrumentParties = val;
            }

            public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoInstrumentParties val)
            {
                return IsSetNoInstrumentParties();
            }

            public bool IsSetNoInstrumentParties()
            {
                return IsSetField(Tags.NoInstrumentParties);
            }

            public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
            {
                get
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnitOfMeasure val)
            {
                this.UnitOfMeasure = val;
            }

            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnitOfMeasure val)
            {
                return IsSetUnitOfMeasure();
            }

            public bool IsSetUnitOfMeasure()
            {
                return IsSetField(Tags.UnitOfMeasure);
            }

            public QuickFix.Fields.TimeUnit TimeUnit
            {
                get
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TimeUnit val)
            {
                this.TimeUnit = val;
            }

            public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TimeUnit val)
            {
                return IsSetTimeUnit();
            }

            public bool IsSetTimeUnit()
            {
                return IsSetField(Tags.TimeUnit);
            }

            public QuickFix.Fields.MaturityTime MaturityTime
            {
                get
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityTime val)
            {
                this.MaturityTime = val;
            }

            public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityTime val)
            {
                return IsSetMaturityTime();
            }

            public bool IsSetMaturityTime()
            {
                return IsSetField(Tags.MaturityTime);
            }

            public QuickFix.Fields.AgreementDesc AgreementDesc
            {
                get
                {
                    QuickFix.Fields.AgreementDesc val = new QuickFix.Fields.AgreementDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AgreementDesc val)
            {
                this.AgreementDesc = val;
            }

            public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AgreementDesc val)
            {
                return IsSetAgreementDesc();
            }

            public bool IsSetAgreementDesc()
            {
                return IsSetField(Tags.AgreementDesc);
            }

            public QuickFix.Fields.AgreementID AgreementID
            {
                get
                {
                    QuickFix.Fields.AgreementID val = new QuickFix.Fields.AgreementID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AgreementID val)
            {
                this.AgreementID = val;
            }

            public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AgreementID val)
            {
                return IsSetAgreementID();
            }

            public bool IsSetAgreementID()
            {
                return IsSetField(Tags.AgreementID);
            }

            public QuickFix.Fields.AgreementDate AgreementDate
            {
                get
                {
                    QuickFix.Fields.AgreementDate val = new QuickFix.Fields.AgreementDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AgreementDate val)
            {
                this.AgreementDate = val;
            }

            public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AgreementDate val)
            {
                return IsSetAgreementDate();
            }

            public bool IsSetAgreementDate()
            {
                return IsSetField(Tags.AgreementDate);
            }

            public QuickFix.Fields.AgreementCurrency AgreementCurrency
            {
                get
                {
                    QuickFix.Fields.AgreementCurrency val = new QuickFix.Fields.AgreementCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AgreementCurrency val)
            {
                this.AgreementCurrency = val;
            }

            public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AgreementCurrency val)
            {
                return IsSetAgreementCurrency();
            }

            public bool IsSetAgreementCurrency()
            {
                return IsSetField(Tags.AgreementCurrency);
            }

            public QuickFix.Fields.TerminationType TerminationType
            {
                get
                {
                    QuickFix.Fields.TerminationType val = new QuickFix.Fields.TerminationType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TerminationType val)
            {
                this.TerminationType = val;
            }

            public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TerminationType val)
            {
                return IsSetTerminationType();
            }

            public bool IsSetTerminationType()
            {
                return IsSetField(Tags.TerminationType);
            }

            public QuickFix.Fields.StartDate StartDate
            {
                get
                {
                    QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StartDate val)
            {
                this.StartDate = val;
            }

            public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StartDate val)
            {
                return IsSetStartDate();
            }

            public bool IsSetStartDate()
            {
                return IsSetField(Tags.StartDate);
            }

            public QuickFix.Fields.EndDate EndDate
            {
                get
                {
                    QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EndDate val)
            {
                this.EndDate = val;
            }

            public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EndDate val)
            {
                return IsSetEndDate();
            }

            public bool IsSetEndDate()
            {
                return IsSetField(Tags.EndDate);
            }

            public QuickFix.Fields.DeliveryType DeliveryType
            {
                get
                {
                    QuickFix.Fields.DeliveryType val = new QuickFix.Fields.DeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.DeliveryType val)
            {
                this.DeliveryType = val;
            }

            public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.DeliveryType val)
            {
                return IsSetDeliveryType();
            }

            public bool IsSetDeliveryType()
            {
                return IsSetField(Tags.DeliveryType);
            }

            public QuickFix.Fields.MarginRatio MarginRatio
            {
                get
                {
                    QuickFix.Fields.MarginRatio val = new QuickFix.Fields.MarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarginRatio val)
            {
                this.MarginRatio = val;
            }

            public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarginRatio val)
            {
                return IsSetMarginRatio();
            }

            public bool IsSetMarginRatio()
            {
                return IsSetField(Tags.MarginRatio);
            }

            public QuickFix.Fields.SettlDate SettlDate
            {
                get
                {
                    QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlDate val)
            {
                this.SettlDate = val;
            }

            public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlDate val)
            {
                return IsSetSettlDate();
            }

            public bool IsSetSettlDate()
            {
                return IsSetField(Tags.SettlDate);
            }

            public QuickFix.Fields.Quantity Quantity
            {
                get
                {
                    QuickFix.Fields.Quantity val = new QuickFix.Fields.Quantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Quantity val)
            {
                this.Quantity = val;
            }

            public QuickFix.Fields.Quantity Get(QuickFix.Fields.Quantity val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Quantity val)
            {
                return IsSetQuantity();
            }

            public bool IsSetQuantity()
            {
                return IsSetField(Tags.Quantity);
            }

            public QuickFix.Fields.QtyType QtyType
            {
                get
                {
                    QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QtyType val)
            {
                this.QtyType = val;
            }

            public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QtyType val)
            {
                return IsSetQtyType();
            }

            public bool IsSetQtyType()
            {
                return IsSetField(Tags.QtyType);
            }

            public QuickFix.Fields.Currency Currency
            {
                get
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Currency val)
            {
                this.Currency = val;
            }

            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Currency val)
            {
                return IsSetCurrency();
            }

            public bool IsSetCurrency()
            {
                return IsSetField(Tags.Currency);
            }

            public QuickFix.Fields.NoLegs NoLegs
            {
                get
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoLegs val)
            {
                this.NoLegs = val;
            }

            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoLegs val)
            {
                return IsSetNoLegs();
            }

            public bool IsSetNoLegs()
            {
                return IsSetField(Tags.NoLegs);
            }

            public QuickFix.Fields.NoUnderlyings NoUnderlyings
            {
                get
                {
                    QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoUnderlyings val)
            {
                this.NoUnderlyings = val;
            }

            public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoUnderlyings val)
            {
                return IsSetNoUnderlyings();
            }

            public bool IsSetNoUnderlyings()
            {
                return IsSetField(Tags.NoUnderlyings);
            }

            public QuickFix.Fields.MarginExcess MarginExcess
            {
                get
                {
                    QuickFix.Fields.MarginExcess val = new QuickFix.Fields.MarginExcess();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarginExcess val)
            {
                this.MarginExcess = val;
            }

            public QuickFix.Fields.MarginExcess Get(QuickFix.Fields.MarginExcess val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarginExcess val)
            {
                return IsSetMarginExcess();
            }

            public bool IsSetMarginExcess()
            {
                return IsSetField(Tags.MarginExcess);
            }

            public QuickFix.Fields.TotalNetValue TotalNetValue
            {
                get
                {
                    QuickFix.Fields.TotalNetValue val = new QuickFix.Fields.TotalNetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotalNetValue val)
            {
                this.TotalNetValue = val;
            }

            public QuickFix.Fields.TotalNetValue Get(QuickFix.Fields.TotalNetValue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotalNetValue val)
            {
                return IsSetTotalNetValue();
            }

            public bool IsSetTotalNetValue()
            {
                return IsSetField(Tags.TotalNetValue);
            }

            public QuickFix.Fields.CashOutstanding CashOutstanding
            {
                get
                {
                    QuickFix.Fields.CashOutstanding val = new QuickFix.Fields.CashOutstanding();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CashOutstanding val)
            {
                this.CashOutstanding = val;
            }

            public QuickFix.Fields.CashOutstanding Get(QuickFix.Fields.CashOutstanding val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CashOutstanding val)
            {
                return IsSetCashOutstanding();
            }

            public bool IsSetCashOutstanding()
            {
                return IsSetField(Tags.CashOutstanding);
            }

            public QuickFix.Fields.NoTrdRegTimestamps NoTrdRegTimestamps
            {
                get
                {
                    QuickFix.Fields.NoTrdRegTimestamps val = new QuickFix.Fields.NoTrdRegTimestamps();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoTrdRegTimestamps val)
            {
                this.NoTrdRegTimestamps = val;
            }

            public QuickFix.Fields.NoTrdRegTimestamps Get(QuickFix.Fields.NoTrdRegTimestamps val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoTrdRegTimestamps val)
            {
                return IsSetNoTrdRegTimestamps();
            }

            public bool IsSetNoTrdRegTimestamps()
            {
                return IsSetField(Tags.NoTrdRegTimestamps);
            }

            public QuickFix.Fields.Side Side
            {
                get
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Side val)
            {
                this.Side = val;
            }

            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Side val)
            {
                return IsSetSide();
            }

            public bool IsSetSide()
            {
                return IsSetField(Tags.Side);
            }

            public QuickFix.Fields.NoMiscFees NoMiscFees
            {
                get
                {
                    QuickFix.Fields.NoMiscFees val = new QuickFix.Fields.NoMiscFees();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMiscFees val)
            {
                this.NoMiscFees = val;
            }

            public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMiscFees val)
            {
                return IsSetNoMiscFees();
            }

            public bool IsSetNoMiscFees()
            {
                return IsSetField(Tags.NoMiscFees);
            }

            public QuickFix.Fields.Price Price
            {
                get
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Price val)
            {
                this.Price = val;
            }

            public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Price val)
            {
                return IsSetPrice();
            }

            public bool IsSetPrice()
            {
                return IsSetField(Tags.Price);
            }

            public QuickFix.Fields.PriceType PriceType
            {
                get
                {
                    QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PriceType val)
            {
                this.PriceType = val;
            }

            public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PriceType val)
            {
                return IsSetPriceType();
            }

            public bool IsSetPriceType()
            {
                return IsSetField(Tags.PriceType);
            }

            public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
            {
                get
                {
                    QuickFix.Fields.AccruedInterestAmt val = new QuickFix.Fields.AccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AccruedInterestAmt val)
            {
                this.AccruedInterestAmt = val;
            }

            public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AccruedInterestAmt val)
            {
                return IsSetAccruedInterestAmt();
            }

            public bool IsSetAccruedInterestAmt()
            {
                return IsSetField(Tags.AccruedInterestAmt);
            }

            public QuickFix.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
            {
                get
                {
                    QuickFix.Fields.EndAccruedInterestAmt val = new QuickFix.Fields.EndAccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EndAccruedInterestAmt val)
            {
                this.EndAccruedInterestAmt = val;
            }

            public QuickFix.Fields.EndAccruedInterestAmt Get(QuickFix.Fields.EndAccruedInterestAmt val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EndAccruedInterestAmt val)
            {
                return IsSetEndAccruedInterestAmt();
            }

            public bool IsSetEndAccruedInterestAmt()
            {
                return IsSetField(Tags.EndAccruedInterestAmt);
            }

            public QuickFix.Fields.StartCash StartCash
            {
                get
                {
                    QuickFix.Fields.StartCash val = new QuickFix.Fields.StartCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StartCash val)
            {
                this.StartCash = val;
            }

            public QuickFix.Fields.StartCash Get(QuickFix.Fields.StartCash val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StartCash val)
            {
                return IsSetStartCash();
            }

            public bool IsSetStartCash()
            {
                return IsSetField(Tags.StartCash);
            }

            public QuickFix.Fields.EndCash EndCash
            {
                get
                {
                    QuickFix.Fields.EndCash val = new QuickFix.Fields.EndCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EndCash val)
            {
                this.EndCash = val;
            }

            public QuickFix.Fields.EndCash Get(QuickFix.Fields.EndCash val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EndCash val)
            {
                return IsSetEndCash();
            }

            public bool IsSetEndCash()
            {
                return IsSetField(Tags.EndCash);
            }

            public QuickFix.Fields.Spread Spread
            {
                get
                {
                    QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Spread val)
            {
                this.Spread = val;
            }

            public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Spread val)
            {
                return IsSetSpread();
            }

            public bool IsSetSpread()
            {
                return IsSetField(Tags.Spread);
            }

            public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            {
                get
                {
                    QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkCurveCurrency val)
            {
                this.BenchmarkCurveCurrency = val;
            }

            public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val)
            {
                return IsSetBenchmarkCurveCurrency();
            }

            public bool IsSetBenchmarkCurveCurrency()
            {
                return IsSetField(Tags.BenchmarkCurveCurrency);
            }

            public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
            {
                get
                {
                    QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkCurveName val)
            {
                this.BenchmarkCurveName = val;
            }

            public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkCurveName val)
            {
                return IsSetBenchmarkCurveName();
            }

            public bool IsSetBenchmarkCurveName()
            {
                return IsSetField(Tags.BenchmarkCurveName);
            }

            public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            {
                get
                {
                    QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkCurvePoint val)
            {
                this.BenchmarkCurvePoint = val;
            }

            public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val)
            {
                return IsSetBenchmarkCurvePoint();
            }

            public bool IsSetBenchmarkCurvePoint()
            {
                return IsSetField(Tags.BenchmarkCurvePoint);
            }

            public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
            {
                get
                {
                    QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkPrice val)
            {
                this.BenchmarkPrice = val;
            }

            public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkPrice val)
            {
                return IsSetBenchmarkPrice();
            }

            public bool IsSetBenchmarkPrice()
            {
                return IsSetField(Tags.BenchmarkPrice);
            }

            public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
            {
                get
                {
                    QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkPriceType val)
            {
                this.BenchmarkPriceType = val;
            }

            public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkPriceType val)
            {
                return IsSetBenchmarkPriceType();
            }

            public bool IsSetBenchmarkPriceType()
            {
                return IsSetField(Tags.BenchmarkPriceType);
            }

            public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
            {
                get
                {
                    QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkSecurityID val)
            {
                this.BenchmarkSecurityID = val;
            }

            public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val)
            {
                return IsSetBenchmarkSecurityID();
            }

            public bool IsSetBenchmarkSecurityID()
            {
                return IsSetField(Tags.BenchmarkSecurityID);
            }

            public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            {
                get
                {
                    QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val)
            {
                this.BenchmarkSecurityIDSource = val;
            }

            public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val)
            {
                return IsSetBenchmarkSecurityIDSource();
            }

            public bool IsSetBenchmarkSecurityIDSource()
            {
                return IsSetField(Tags.BenchmarkSecurityIDSource);
            }

            public QuickFix.Fields.NoStipulations NoStipulations
            {
                get
                {
                    QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoStipulations val)
            {
                this.NoStipulations = val;
            }

            public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoStipulations val)
            {
                return IsSetNoStipulations();
            }

            public bool IsSetNoStipulations()
            {
                return IsSetField(Tags.NoStipulations);
            }

            public QuickFix.Fields.SettlDeliveryType SettlDeliveryType
            {
                get
                {
                    QuickFix.Fields.SettlDeliveryType val = new QuickFix.Fields.SettlDeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlDeliveryType val)
            {
                this.SettlDeliveryType = val;
            }

            public QuickFix.Fields.SettlDeliveryType Get(QuickFix.Fields.SettlDeliveryType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlDeliveryType val)
            {
                return IsSetSettlDeliveryType();
            }

            public bool IsSetSettlDeliveryType()
            {
                return IsSetField(Tags.SettlDeliveryType);
            }

            public QuickFix.Fields.StandInstDbType StandInstDbType
            {
                get
                {
                    QuickFix.Fields.StandInstDbType val = new QuickFix.Fields.StandInstDbType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StandInstDbType val)
            {
                this.StandInstDbType = val;
            }

            public QuickFix.Fields.StandInstDbType Get(QuickFix.Fields.StandInstDbType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StandInstDbType val)
            {
                return IsSetStandInstDbType();
            }

            public bool IsSetStandInstDbType()
            {
                return IsSetField(Tags.StandInstDbType);
            }

            public QuickFix.Fields.StandInstDbName StandInstDbName
            {
                get
                {
                    QuickFix.Fields.StandInstDbName val = new QuickFix.Fields.StandInstDbName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StandInstDbName val)
            {
                this.StandInstDbName = val;
            }

            public QuickFix.Fields.StandInstDbName Get(QuickFix.Fields.StandInstDbName val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StandInstDbName val)
            {
                return IsSetStandInstDbName();
            }

            public bool IsSetStandInstDbName()
            {
                return IsSetField(Tags.StandInstDbName);
            }

            public QuickFix.Fields.StandInstDbID StandInstDbID
            {
                get
                {
                    QuickFix.Fields.StandInstDbID val = new QuickFix.Fields.StandInstDbID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StandInstDbID val)
            {
                this.StandInstDbID = val;
            }

            public QuickFix.Fields.StandInstDbID Get(QuickFix.Fields.StandInstDbID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StandInstDbID val)
            {
                return IsSetStandInstDbID();
            }

            public bool IsSetStandInstDbID()
            {
                return IsSetField(Tags.StandInstDbID);
            }

            public QuickFix.Fields.NoDlvyInst NoDlvyInst
            {
                get
                {
                    QuickFix.Fields.NoDlvyInst val = new QuickFix.Fields.NoDlvyInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoDlvyInst val)
            {
                this.NoDlvyInst = val;
            }

            public QuickFix.Fields.NoDlvyInst Get(QuickFix.Fields.NoDlvyInst val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoDlvyInst val)
            {
                return IsSetNoDlvyInst();
            }

            public bool IsSetNoDlvyInst()
            {
                return IsSetField(Tags.NoDlvyInst);
            }

            public QuickFix.Fields.TradingSessionID TradingSessionID
            {
                get
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingSessionID val)
            {
                this.TradingSessionID = val;
            }

            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingSessionID val)
            {
                return IsSetTradingSessionID();
            }

            public bool IsSetTradingSessionID()
            {
                return IsSetField(Tags.TradingSessionID);
            }

            public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
            {
                get
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingSessionSubID val)
            {
                this.TradingSessionSubID = val;
            }

            public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingSessionSubID val)
            {
                return IsSetTradingSessionSubID();
            }

            public bool IsSetTradingSessionSubID()
            {
                return IsSetField(Tags.TradingSessionSubID);
            }

            public QuickFix.Fields.SettlSessID SettlSessID
            {
                get
                {
                    QuickFix.Fields.SettlSessID val = new QuickFix.Fields.SettlSessID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlSessID val)
            {
                this.SettlSessID = val;
            }

            public QuickFix.Fields.SettlSessID Get(QuickFix.Fields.SettlSessID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlSessID val)
            {
                return IsSetSettlSessID();
            }

            public bool IsSetSettlSessID()
            {
                return IsSetField(Tags.SettlSessID);
            }

            public QuickFix.Fields.SettlSessSubID SettlSessSubID
            {
                get
                {
                    QuickFix.Fields.SettlSessSubID val = new QuickFix.Fields.SettlSessSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SettlSessSubID val)
            {
                this.SettlSessSubID = val;
            }

            public QuickFix.Fields.SettlSessSubID Get(QuickFix.Fields.SettlSessSubID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SettlSessSubID val)
            {
                return IsSetSettlSessSubID();
            }

            public bool IsSetSettlSessSubID()
            {
                return IsSetField(Tags.SettlSessSubID);
            }

            public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
            {
                get
                {
                    QuickFix.Fields.ClearingBusinessDate val = new QuickFix.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClearingBusinessDate val)
            {
                this.ClearingBusinessDate = val;
            }

            public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClearingBusinessDate val)
            {
                return IsSetClearingBusinessDate();
            }

            public bool IsSetClearingBusinessDate()
            {
                return IsSetField(Tags.ClearingBusinessDate);
            }

            public QuickFix.Fields.Text Text
            {
                get
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Text val)
            {
                this.Text = val;
            }

            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Text val)
            {
                return IsSetText();
            }

            public bool IsSetText()
            {
                return IsSetField(Tags.Text);
            }

            public QuickFix.Fields.EncodedTextLen EncodedTextLen
            {
                get
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedTextLen val)
            {
                this.EncodedTextLen = val;
            }

            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedTextLen val)
            {
                return IsSetEncodedTextLen();
            }

            public bool IsSetEncodedTextLen()
            {
                return IsSetField(Tags.EncodedTextLen);
            }

            public QuickFix.Fields.EncodedText EncodedText
            {
                get
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedText val)
            {
                this.EncodedText = val;
            }

            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedText val)
            {
                return IsSetEncodedText();
            }

            public bool IsSetEncodedText()
            {
                return IsSetField(Tags.EncodedText);
            }

            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

                public NoPartyIDsGroup()
                  : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PartyID PartyID
                {
                    get
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyID val)
                {
                    this.PartyID = val;
                }

                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyID val)
                {
                    return IsSetPartyID();
                }

                public bool IsSetPartyID()
                {
                    return IsSetField(Tags.PartyID);
                }

                public QuickFix.Fields.PartyIDSource PartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyIDSource val)
                {
                    this.PartyIDSource = val;
                }

                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyIDSource val)
                {
                    return IsSetPartyIDSource();
                }

                public bool IsSetPartyIDSource()
                {
                    return IsSetField(Tags.PartyIDSource);
                }

                public QuickFix.Fields.PartyRole PartyRole
                {
                    get
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRole val)
                {
                    this.PartyRole = val;
                }

                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRole val)
                {
                    return IsSetPartyRole();
                }

                public bool IsSetPartyRole()
                {
                    return IsSetField(Tags.PartyRole);
                }

                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartySubIDs val)
                {
                    this.NoPartySubIDs = val;
                }

                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartySubIDs val)
                {
                    return IsSetNoPartySubIDs();
                }

                public bool IsSetNoPartySubIDs()
                {
                    return IsSetField(Tags.NoPartySubIDs);
                }

                public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

                    public NoPartySubIDsGroup()
                      : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartySubID PartySubID
                    {
                        get
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubID val)
                    {
                        this.PartySubID = val;
                    }

                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubID val)
                    {
                        return IsSetPartySubID();
                    }

                    public bool IsSetPartySubID()
                    {
                        return IsSetField(Tags.PartySubID);
                    }

                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubIDType val)
                    {
                        this.PartySubIDType = val;
                    }

                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubIDType val)
                    {
                        return IsSetPartySubIDType();
                    }

                    public bool IsSetPartySubIDType()
                    {
                        return IsSetField(Tags.PartySubIDType);
                    }


                }
            }
            public class NoExecsGroup : Group
            {
                public static int[] fieldOrder = {Tags.ExecID, 0};

                public NoExecsGroup()
                  : base(Tags.NoExecs, Tags.ExecID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoExecsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.ExecID ExecID
                {
                    get
                    {
                        QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.ExecID val)
                {
                    this.ExecID = val;
                }

                public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.ExecID val)
                {
                    return IsSetExecID();
                }

                public bool IsSetExecID()
                {
                    return IsSetField(Tags.ExecID);
                }


            }
            public class NoTradesGroup : Group
            {
                public static int[] fieldOrder = {Tags.TradeReportID, Tags.SecondaryTradeReportID, 0};

                public NoTradesGroup()
                  : base(Tags.NoTrades, Tags.TradeReportID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTradesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.TradeReportID TradeReportID
                {
                    get
                    {
                        QuickFix.Fields.TradeReportID val = new QuickFix.Fields.TradeReportID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TradeReportID val)
                {
                    this.TradeReportID = val;
                }

                public QuickFix.Fields.TradeReportID Get(QuickFix.Fields.TradeReportID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TradeReportID val)
                {
                    return IsSetTradeReportID();
                }

                public bool IsSetTradeReportID()
                {
                    return IsSetField(Tags.TradeReportID);
                }

                public QuickFix.Fields.SecondaryTradeReportID SecondaryTradeReportID
                {
                    get
                    {
                        QuickFix.Fields.SecondaryTradeReportID val = new QuickFix.Fields.SecondaryTradeReportID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecondaryTradeReportID val)
                {
                    this.SecondaryTradeReportID = val;
                }

                public QuickFix.Fields.SecondaryTradeReportID Get(QuickFix.Fields.SecondaryTradeReportID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecondaryTradeReportID val)
                {
                    return IsSetSecondaryTradeReportID();
                }

                public bool IsSetSecondaryTradeReportID()
                {
                    return IsSetField(Tags.SecondaryTradeReportID);
                }


            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

                public NoSecurityAltIDGroup()
                  : base(Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.SecurityAltID SecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityAltID val)
                {
                    this.SecurityAltID = val;
                }

                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityAltID val)
                {
                    return IsSetSecurityAltID();
                }

                public bool IsSetSecurityAltID()
                {
                    return IsSetField(Tags.SecurityAltID);
                }

                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                {
                    get
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityAltIDSource val)
                {
                    this.SecurityAltIDSource = val;
                }

                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val)
                {
                    return IsSetSecurityAltIDSource();
                }

                public bool IsSetSecurityAltIDSource()
                {
                    return IsSetField(Tags.SecurityAltIDSource);
                }


            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};

                public NoEventsGroup()
                  : base(Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.EventType EventType
                {
                    get
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EventType val)
                {
                    this.EventType = val;
                }

                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EventType val)
                {
                    return IsSetEventType();
                }

                public bool IsSetEventType()
                {
                    return IsSetField(Tags.EventType);
                }

                public QuickFix.Fields.EventDate EventDate
                {
                    get
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EventDate val)
                {
                    this.EventDate = val;
                }

                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EventDate val)
                {
                    return IsSetEventDate();
                }

                public bool IsSetEventDate()
                {
                    return IsSetField(Tags.EventDate);
                }

                public QuickFix.Fields.EventPx EventPx
                {
                    get
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EventPx val)
                {
                    this.EventPx = val;
                }

                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EventPx val)
                {
                    return IsSetEventPx();
                }

                public bool IsSetEventPx()
                {
                    return IsSetField(Tags.EventPx);
                }

                public QuickFix.Fields.EventText EventText
                {
                    get
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EventText val)
                {
                    this.EventText = val;
                }

                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EventText val)
                {
                    return IsSetEventText();
                }

                public bool IsSetEventText()
                {
                    return IsSetField(Tags.EventText);
                }


            }
            public class NoInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

                public NoInstrumentPartiesGroup()
                  : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoInstrumentPartiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
                {
                    get
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.InstrumentPartyID val)
                {
                    this.InstrumentPartyID = val;
                }

                public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.InstrumentPartyID val)
                {
                    return IsSetInstrumentPartyID();
                }

                public bool IsSetInstrumentPartyID()
                {
                    return IsSetField(Tags.InstrumentPartyID);
                }

                public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.InstrumentPartyIDSource val)
                {
                    this.InstrumentPartyIDSource = val;
                }

                public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val)
                {
                    return IsSetInstrumentPartyIDSource();
                }

                public bool IsSetInstrumentPartyIDSource()
                {
                    return IsSetField(Tags.InstrumentPartyIDSource);
                }

                public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
                {
                    get
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.InstrumentPartyRole val)
                {
                    this.InstrumentPartyRole = val;
                }

                public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.InstrumentPartyRole val)
                {
                    return IsSetInstrumentPartyRole();
                }

                public bool IsSetInstrumentPartyRole()
                {
                    return IsSetField(Tags.InstrumentPartyRole);
                }

                public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val)
                {
                    this.NoInstrumentPartySubIDs = val;
                }

                public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val)
                {
                    return IsSetNoInstrumentPartySubIDs();
                }

                public bool IsSetNoInstrumentPartySubIDs()
                {
                    return IsSetField(Tags.NoInstrumentPartySubIDs);
                }

                public class NoInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

                    public NoInstrumentPartySubIDsGroup()
                      : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoInstrumentPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
                    {
                        get
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.InstrumentPartySubID val)
                    {
                        this.InstrumentPartySubID = val;
                    }

                    public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.InstrumentPartySubID val)
                    {
                        return IsSetInstrumentPartySubID();
                    }

                    public bool IsSetInstrumentPartySubID()
                    {
                        return IsSetField(Tags.InstrumentPartySubID);
                    }

                    public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.InstrumentPartySubIDType val)
                    {
                        this.InstrumentPartySubIDType = val;
                    }

                    public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val)
                    {
                        return IsSetInstrumentPartySubIDType();
                    }

                    public bool IsSetInstrumentPartySubIDType()
                    {
                        return IsSetField(Tags.InstrumentPartySubIDType);
                    }


                }
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, 0};

                public NoLegsGroup()
                  : base(Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.LegSymbol LegSymbol
                {
                    get
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSymbol val)
                {
                    this.LegSymbol = val;
                }

                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSymbol val)
                {
                    return IsSetLegSymbol();
                }

                public bool IsSetLegSymbol()
                {
                    return IsSetField(Tags.LegSymbol);
                }

                public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                {
                    get
                    {
                        QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSymbolSfx val)
                {
                    this.LegSymbolSfx = val;
                }

                public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSymbolSfx val)
                {
                    return IsSetLegSymbolSfx();
                }

                public bool IsSetLegSymbolSfx()
                {
                    return IsSetField(Tags.LegSymbolSfx);
                }

                public QuickFix.Fields.LegSecurityID LegSecurityID
                {
                    get
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecurityID val)
                {
                    this.LegSecurityID = val;
                }

                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecurityID val)
                {
                    return IsSetLegSecurityID();
                }

                public bool IsSetLegSecurityID()
                {
                    return IsSetField(Tags.LegSecurityID);
                }

                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                {
                    get
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecurityIDSource val)
                {
                    this.LegSecurityIDSource = val;
                }

                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val)
                {
                    return IsSetLegSecurityIDSource();
                }

                public bool IsSetLegSecurityIDSource()
                {
                    return IsSetField(Tags.LegSecurityIDSource);
                }

                public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoLegSecurityAltID val)
                {
                    this.NoLegSecurityAltID = val;
                }

                public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val)
                {
                    return IsSetNoLegSecurityAltID();
                }

                public bool IsSetNoLegSecurityAltID()
                {
                    return IsSetField(Tags.NoLegSecurityAltID);
                }

                public QuickFix.Fields.LegProduct LegProduct
                {
                    get
                    {
                        QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegProduct val)
                {
                    this.LegProduct = val;
                }

                public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegProduct val)
                {
                    return IsSetLegProduct();
                }

                public bool IsSetLegProduct()
                {
                    return IsSetField(Tags.LegProduct);
                }

                public QuickFix.Fields.LegCFICode LegCFICode
                {
                    get
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCFICode val)
                {
                    this.LegCFICode = val;
                }

                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCFICode val)
                {
                    return IsSetLegCFICode();
                }

                public bool IsSetLegCFICode()
                {
                    return IsSetField(Tags.LegCFICode);
                }

                public QuickFix.Fields.LegSecurityType LegSecurityType
                {
                    get
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecurityType val)
                {
                    this.LegSecurityType = val;
                }

                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecurityType val)
                {
                    return IsSetLegSecurityType();
                }

                public bool IsSetLegSecurityType()
                {
                    return IsSetField(Tags.LegSecurityType);
                }

                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                {
                    get
                    {
                        QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecuritySubType val)
                {
                    this.LegSecuritySubType = val;
                }

                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecuritySubType val)
                {
                    return IsSetLegSecuritySubType();
                }

                public bool IsSetLegSecuritySubType()
                {
                    return IsSetField(Tags.LegSecuritySubType);
                }

                public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                {
                    get
                    {
                        QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegMaturityMonthYear val)
                {
                    this.LegMaturityMonthYear = val;
                }

                public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val)
                {
                    return IsSetLegMaturityMonthYear();
                }

                public bool IsSetLegMaturityMonthYear()
                {
                    return IsSetField(Tags.LegMaturityMonthYear);
                }

                public QuickFix.Fields.LegMaturityDate LegMaturityDate
                {
                    get
                    {
                        QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegMaturityDate val)
                {
                    this.LegMaturityDate = val;
                }

                public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegMaturityDate val)
                {
                    return IsSetLegMaturityDate();
                }

                public bool IsSetLegMaturityDate()
                {
                    return IsSetField(Tags.LegMaturityDate);
                }

                public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                {
                    get
                    {
                        QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCouponPaymentDate val)
                {
                    this.LegCouponPaymentDate = val;
                }

                public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val)
                {
                    return IsSetLegCouponPaymentDate();
                }

                public bool IsSetLegCouponPaymentDate()
                {
                    return IsSetField(Tags.LegCouponPaymentDate);
                }

                public QuickFix.Fields.LegIssueDate LegIssueDate
                {
                    get
                    {
                        QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegIssueDate val)
                {
                    this.LegIssueDate = val;
                }

                public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegIssueDate val)
                {
                    return IsSetLegIssueDate();
                }

                public bool IsSetLegIssueDate()
                {
                    return IsSetField(Tags.LegIssueDate);
                }

                public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                {
                    get
                    {
                        QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val)
                {
                    this.LegRepoCollateralSecurityType = val;
                }

                public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val)
                {
                    return IsSetLegRepoCollateralSecurityType();
                }

                public bool IsSetLegRepoCollateralSecurityType()
                {
                    return IsSetField(Tags.LegRepoCollateralSecurityType);
                }

                public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                {
                    get
                    {
                        QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegRepurchaseTerm val)
                {
                    this.LegRepurchaseTerm = val;
                }

                public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val)
                {
                    return IsSetLegRepurchaseTerm();
                }

                public bool IsSetLegRepurchaseTerm()
                {
                    return IsSetField(Tags.LegRepurchaseTerm);
                }

                public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                {
                    get
                    {
                        QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegRepurchaseRate val)
                {
                    this.LegRepurchaseRate = val;
                }

                public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegRepurchaseRate val)
                {
                    return IsSetLegRepurchaseRate();
                }

                public bool IsSetLegRepurchaseRate()
                {
                    return IsSetField(Tags.LegRepurchaseRate);
                }

                public QuickFix.Fields.LegFactor LegFactor
                {
                    get
                    {
                        QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegFactor val)
                {
                    this.LegFactor = val;
                }

                public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegFactor val)
                {
                    return IsSetLegFactor();
                }

                public bool IsSetLegFactor()
                {
                    return IsSetField(Tags.LegFactor);
                }

                public QuickFix.Fields.LegCreditRating LegCreditRating
                {
                    get
                    {
                        QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCreditRating val)
                {
                    this.LegCreditRating = val;
                }

                public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCreditRating val)
                {
                    return IsSetLegCreditRating();
                }

                public bool IsSetLegCreditRating()
                {
                    return IsSetField(Tags.LegCreditRating);
                }

                public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                {
                    get
                    {
                        QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegInstrRegistry val)
                {
                    this.LegInstrRegistry = val;
                }

                public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegInstrRegistry val)
                {
                    return IsSetLegInstrRegistry();
                }

                public bool IsSetLegInstrRegistry()
                {
                    return IsSetField(Tags.LegInstrRegistry);
                }

                public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                {
                    get
                    {
                        QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCountryOfIssue val)
                {
                    this.LegCountryOfIssue = val;
                }

                public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCountryOfIssue val)
                {
                    return IsSetLegCountryOfIssue();
                }

                public bool IsSetLegCountryOfIssue()
                {
                    return IsSetField(Tags.LegCountryOfIssue);
                }

                public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                {
                    get
                    {
                        QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val)
                {
                    this.LegStateOrProvinceOfIssue = val;
                }

                public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val)
                {
                    return IsSetLegStateOrProvinceOfIssue();
                }

                public bool IsSetLegStateOrProvinceOfIssue()
                {
                    return IsSetField(Tags.LegStateOrProvinceOfIssue);
                }

                public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                {
                    get
                    {
                        QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegLocaleOfIssue val)
                {
                    this.LegLocaleOfIssue = val;
                }

                public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val)
                {
                    return IsSetLegLocaleOfIssue();
                }

                public bool IsSetLegLocaleOfIssue()
                {
                    return IsSetField(Tags.LegLocaleOfIssue);
                }

                public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                {
                    get
                    {
                        QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegRedemptionDate val)
                {
                    this.LegRedemptionDate = val;
                }

                public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegRedemptionDate val)
                {
                    return IsSetLegRedemptionDate();
                }

                public bool IsSetLegRedemptionDate()
                {
                    return IsSetField(Tags.LegRedemptionDate);
                }

                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                {
                    get
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegStrikePrice val)
                {
                    this.LegStrikePrice = val;
                }

                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegStrikePrice val)
                {
                    return IsSetLegStrikePrice();
                }

                public bool IsSetLegStrikePrice()
                {
                    return IsSetField(Tags.LegStrikePrice);
                }

                public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                {
                    get
                    {
                        QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegStrikeCurrency val)
                {
                    this.LegStrikeCurrency = val;
                }

                public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegStrikeCurrency val)
                {
                    return IsSetLegStrikeCurrency();
                }

                public bool IsSetLegStrikeCurrency()
                {
                    return IsSetField(Tags.LegStrikeCurrency);
                }

                public QuickFix.Fields.LegOptAttribute LegOptAttribute
                {
                    get
                    {
                        QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegOptAttribute val)
                {
                    this.LegOptAttribute = val;
                }

                public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegOptAttribute val)
                {
                    return IsSetLegOptAttribute();
                }

                public bool IsSetLegOptAttribute()
                {
                    return IsSetField(Tags.LegOptAttribute);
                }

                public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                {
                    get
                    {
                        QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegContractMultiplier val)
                {
                    this.LegContractMultiplier = val;
                }

                public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegContractMultiplier val)
                {
                    return IsSetLegContractMultiplier();
                }

                public bool IsSetLegContractMultiplier()
                {
                    return IsSetField(Tags.LegContractMultiplier);
                }

                public QuickFix.Fields.LegCouponRate LegCouponRate
                {
                    get
                    {
                        QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCouponRate val)
                {
                    this.LegCouponRate = val;
                }

                public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCouponRate val)
                {
                    return IsSetLegCouponRate();
                }

                public bool IsSetLegCouponRate()
                {
                    return IsSetField(Tags.LegCouponRate);
                }

                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                {
                    get
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecurityExchange val)
                {
                    this.LegSecurityExchange = val;
                }

                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecurityExchange val)
                {
                    return IsSetLegSecurityExchange();
                }

                public bool IsSetLegSecurityExchange()
                {
                    return IsSetField(Tags.LegSecurityExchange);
                }

                public QuickFix.Fields.LegIssuer LegIssuer
                {
                    get
                    {
                        QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegIssuer val)
                {
                    this.LegIssuer = val;
                }

                public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegIssuer val)
                {
                    return IsSetLegIssuer();
                }

                public bool IsSetLegIssuer()
                {
                    return IsSetField(Tags.LegIssuer);
                }

                public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedLegIssuerLen val)
                {
                    this.EncodedLegIssuerLen = val;
                }

                public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val)
                {
                    return IsSetEncodedLegIssuerLen();
                }

                public bool IsSetEncodedLegIssuerLen()
                {
                    return IsSetField(Tags.EncodedLegIssuerLen);
                }

                public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                {
                    get
                    {
                        QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedLegIssuer val)
                {
                    this.EncodedLegIssuer = val;
                }

                public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedLegIssuer val)
                {
                    return IsSetEncodedLegIssuer();
                }

                public bool IsSetEncodedLegIssuer()
                {
                    return IsSetField(Tags.EncodedLegIssuer);
                }

                public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSecurityDesc val)
                {
                    this.LegSecurityDesc = val;
                }

                public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSecurityDesc val)
                {
                    return IsSetLegSecurityDesc();
                }

                public bool IsSetLegSecurityDesc()
                {
                    return IsSetField(Tags.LegSecurityDesc);
                }

                public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val)
                {
                    this.EncodedLegSecurityDescLen = val;
                }

                public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val)
                {
                    return IsSetEncodedLegSecurityDescLen();
                }

                public bool IsSetEncodedLegSecurityDescLen()
                {
                    return IsSetField(Tags.EncodedLegSecurityDescLen);
                }

                public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedLegSecurityDesc val)
                {
                    this.EncodedLegSecurityDesc = val;
                }

                public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val)
                {
                    return IsSetEncodedLegSecurityDesc();
                }

                public bool IsSetEncodedLegSecurityDesc()
                {
                    return IsSetField(Tags.EncodedLegSecurityDesc);
                }

                public QuickFix.Fields.LegRatioQty LegRatioQty
                {
                    get
                    {
                        QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegRatioQty val)
                {
                    this.LegRatioQty = val;
                }

                public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegRatioQty val)
                {
                    return IsSetLegRatioQty();
                }

                public bool IsSetLegRatioQty()
                {
                    return IsSetField(Tags.LegRatioQty);
                }

                public QuickFix.Fields.LegSide LegSide
                {
                    get
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegSide val)
                {
                    this.LegSide = val;
                }

                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegSide val)
                {
                    return IsSetLegSide();
                }

                public bool IsSetLegSide()
                {
                    return IsSetField(Tags.LegSide);
                }

                public QuickFix.Fields.LegCurrency LegCurrency
                {
                    get
                    {
                        QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegCurrency val)
                {
                    this.LegCurrency = val;
                }

                public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegCurrency val)
                {
                    return IsSetLegCurrency();
                }

                public bool IsSetLegCurrency()
                {
                    return IsSetField(Tags.LegCurrency);
                }

                public QuickFix.Fields.LegPool LegPool
                {
                    get
                    {
                        QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegPool val)
                {
                    this.LegPool = val;
                }

                public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegPool val)
                {
                    return IsSetLegPool();
                }

                public bool IsSetLegPool()
                {
                    return IsSetField(Tags.LegPool);
                }

                public QuickFix.Fields.LegDatedDate LegDatedDate
                {
                    get
                    {
                        QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegDatedDate val)
                {
                    this.LegDatedDate = val;
                }

                public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegDatedDate val)
                {
                    return IsSetLegDatedDate();
                }

                public bool IsSetLegDatedDate()
                {
                    return IsSetField(Tags.LegDatedDate);
                }

                public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                {
                    get
                    {
                        QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegContractSettlMonth val)
                {
                    this.LegContractSettlMonth = val;
                }

                public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegContractSettlMonth val)
                {
                    return IsSetLegContractSettlMonth();
                }

                public bool IsSetLegContractSettlMonth()
                {
                    return IsSetField(Tags.LegContractSettlMonth);
                }

                public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                {
                    get
                    {
                        QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegInterestAccrualDate val)
                {
                    this.LegInterestAccrualDate = val;
                }

                public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val)
                {
                    return IsSetLegInterestAccrualDate();
                }

                public bool IsSetLegInterestAccrualDate()
                {
                    return IsSetField(Tags.LegInterestAccrualDate);
                }

                public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
                {
                    get
                    {
                        QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegUnitOfMeasure val)
                {
                    this.LegUnitOfMeasure = val;
                }

                public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val)
                {
                    return IsSetLegUnitOfMeasure();
                }

                public bool IsSetLegUnitOfMeasure()
                {
                    return IsSetField(Tags.LegUnitOfMeasure);
                }

                public QuickFix.Fields.LegTimeUnit LegTimeUnit
                {
                    get
                    {
                        QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.LegTimeUnit val)
                {
                    this.LegTimeUnit = val;
                }

                public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.LegTimeUnit val)
                {
                    return IsSetLegTimeUnit();
                }

                public bool IsSetLegTimeUnit()
                {
                    return IsSetField(Tags.LegTimeUnit);
                }

                public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

                    public NoLegSecurityAltIDGroup()
                      : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                    {
                        get
                        {
                            QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.LegSecurityAltID val)
                    {
                        this.LegSecurityAltID = val;
                    }

                    public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.LegSecurityAltID val)
                    {
                        return IsSetLegSecurityAltID();
                    }

                    public bool IsSetLegSecurityAltID()
                    {
                        return IsSetField(Tags.LegSecurityAltID);
                    }

                    public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    {
                        get
                        {
                            QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.LegSecurityAltIDSource val)
                    {
                        this.LegSecurityAltIDSource = val;
                    }

                    public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val)
                    {
                        return IsSetLegSecurityAltIDSource();
                    }

                    public bool IsSetLegSecurityAltIDSource()
                    {
                        return IsSetField(Tags.LegSecurityAltIDSource);
                    }


                }
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.CollAction, 0};

                public NoUnderlyingsGroup()
                  : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSymbol val)
                {
                    this.UnderlyingSymbol = val;
                }

                public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSymbol val)
                {
                    return IsSetUnderlyingSymbol();
                }

                public bool IsSetUnderlyingSymbol()
                {
                    return IsSetField(Tags.UnderlyingSymbol);
                }

                public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSymbolSfx val)
                {
                    this.UnderlyingSymbolSfx = val;
                }

                public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val)
                {
                    return IsSetUnderlyingSymbolSfx();
                }

                public bool IsSetUnderlyingSymbolSfx()
                {
                    return IsSetField(Tags.UnderlyingSymbolSfx);
                }

                public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityID val)
                {
                    this.UnderlyingSecurityID = val;
                }

                public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val)
                {
                    return IsSetUnderlyingSecurityID();
                }

                public bool IsSetUnderlyingSecurityID()
                {
                    return IsSetField(Tags.UnderlyingSecurityID);
                }

                public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val)
                {
                    this.UnderlyingSecurityIDSource = val;
                }

                public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val)
                {
                    return IsSetUnderlyingSecurityIDSource();
                }

                public bool IsSetUnderlyingSecurityIDSource()
                {
                    return IsSetField(Tags.UnderlyingSecurityIDSource);
                }

                public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val)
                {
                    this.NoUnderlyingSecurityAltID = val;
                }

                public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val)
                {
                    return IsSetNoUnderlyingSecurityAltID();
                }

                public bool IsSetNoUnderlyingSecurityAltID()
                {
                    return IsSetField(Tags.NoUnderlyingSecurityAltID);
                }

                public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingProduct val)
                {
                    this.UnderlyingProduct = val;
                }

                public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingProduct val)
                {
                    return IsSetUnderlyingProduct();
                }

                public bool IsSetUnderlyingProduct()
                {
                    return IsSetField(Tags.UnderlyingProduct);
                }

                public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCFICode val)
                {
                    this.UnderlyingCFICode = val;
                }

                public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCFICode val)
                {
                    return IsSetUnderlyingCFICode();
                }

                public bool IsSetUnderlyingCFICode()
                {
                    return IsSetField(Tags.UnderlyingCFICode);
                }

                public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityType val)
                {
                    this.UnderlyingSecurityType = val;
                }

                public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val)
                {
                    return IsSetUnderlyingSecurityType();
                }

                public bool IsSetUnderlyingSecurityType()
                {
                    return IsSetField(Tags.UnderlyingSecurityType);
                }

                public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecuritySubType val)
                {
                    this.UnderlyingSecuritySubType = val;
                }

                public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val)
                {
                    return IsSetUnderlyingSecuritySubType();
                }

                public bool IsSetUnderlyingSecuritySubType()
                {
                    return IsSetField(Tags.UnderlyingSecuritySubType);
                }

                public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val)
                {
                    this.UnderlyingMaturityMonthYear = val;
                }

                public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val)
                {
                    return IsSetUnderlyingMaturityMonthYear();
                }

                public bool IsSetUnderlyingMaturityMonthYear()
                {
                    return IsSetField(Tags.UnderlyingMaturityMonthYear);
                }

                public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingMaturityDate val)
                {
                    this.UnderlyingMaturityDate = val;
                }

                public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val)
                {
                    return IsSetUnderlyingMaturityDate();
                }

                public bool IsSetUnderlyingMaturityDate()
                {
                    return IsSetField(Tags.UnderlyingMaturityDate);
                }

                public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val)
                {
                    this.UnderlyingCouponPaymentDate = val;
                }

                public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val)
                {
                    return IsSetUnderlyingCouponPaymentDate();
                }

                public bool IsSetUnderlyingCouponPaymentDate()
                {
                    return IsSetField(Tags.UnderlyingCouponPaymentDate);
                }

                public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingIssueDate val)
                {
                    this.UnderlyingIssueDate = val;
                }

                public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val)
                {
                    return IsSetUnderlyingIssueDate();
                }

                public bool IsSetUnderlyingIssueDate()
                {
                    return IsSetField(Tags.UnderlyingIssueDate);
                }

                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
                {
                    this.UnderlyingRepoCollateralSecurityType = val;
                }

                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
                {
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }

                public bool IsSetUnderlyingRepoCollateralSecurityType()
                {
                    return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
                }

                public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val)
                {
                    this.UnderlyingRepurchaseTerm = val;
                }

                public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val)
                {
                    return IsSetUnderlyingRepurchaseTerm();
                }

                public bool IsSetUnderlyingRepurchaseTerm()
                {
                    return IsSetField(Tags.UnderlyingRepurchaseTerm);
                }

                public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val)
                {
                    this.UnderlyingRepurchaseRate = val;
                }

                public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val)
                {
                    return IsSetUnderlyingRepurchaseRate();
                }

                public bool IsSetUnderlyingRepurchaseRate()
                {
                    return IsSetField(Tags.UnderlyingRepurchaseRate);
                }

                public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingFactor val)
                {
                    this.UnderlyingFactor = val;
                }

                public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingFactor val)
                {
                    return IsSetUnderlyingFactor();
                }

                public bool IsSetUnderlyingFactor()
                {
                    return IsSetField(Tags.UnderlyingFactor);
                }

                public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCreditRating val)
                {
                    this.UnderlyingCreditRating = val;
                }

                public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val)
                {
                    return IsSetUnderlyingCreditRating();
                }

                public bool IsSetUnderlyingCreditRating()
                {
                    return IsSetField(Tags.UnderlyingCreditRating);
                }

                public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingInstrRegistry val)
                {
                    this.UnderlyingInstrRegistry = val;
                }

                public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val)
                {
                    return IsSetUnderlyingInstrRegistry();
                }

                public bool IsSetUnderlyingInstrRegistry()
                {
                    return IsSetField(Tags.UnderlyingInstrRegistry);
                }

                public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val)
                {
                    this.UnderlyingCountryOfIssue = val;
                }

                public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val)
                {
                    return IsSetUnderlyingCountryOfIssue();
                }

                public bool IsSetUnderlyingCountryOfIssue()
                {
                    return IsSetField(Tags.UnderlyingCountryOfIssue);
                }

                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
                {
                    this.UnderlyingStateOrProvinceOfIssue = val;
                }

                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
                {
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }

                public bool IsSetUnderlyingStateOrProvinceOfIssue()
                {
                    return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                }

                public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val)
                {
                    this.UnderlyingLocaleOfIssue = val;
                }

                public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val)
                {
                    return IsSetUnderlyingLocaleOfIssue();
                }

                public bool IsSetUnderlyingLocaleOfIssue()
                {
                    return IsSetField(Tags.UnderlyingLocaleOfIssue);
                }

                public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingRedemptionDate val)
                {
                    this.UnderlyingRedemptionDate = val;
                }

                public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val)
                {
                    return IsSetUnderlyingRedemptionDate();
                }

                public bool IsSetUnderlyingRedemptionDate()
                {
                    return IsSetField(Tags.UnderlyingRedemptionDate);
                }

                public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingStrikePrice val)
                {
                    this.UnderlyingStrikePrice = val;
                }

                public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val)
                {
                    return IsSetUnderlyingStrikePrice();
                }

                public bool IsSetUnderlyingStrikePrice()
                {
                    return IsSetField(Tags.UnderlyingStrikePrice);
                }

                public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val)
                {
                    this.UnderlyingStrikeCurrency = val;
                }

                public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val)
                {
                    return IsSetUnderlyingStrikeCurrency();
                }

                public bool IsSetUnderlyingStrikeCurrency()
                {
                    return IsSetField(Tags.UnderlyingStrikeCurrency);
                }

                public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingOptAttribute val)
                {
                    this.UnderlyingOptAttribute = val;
                }

                public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val)
                {
                    return IsSetUnderlyingOptAttribute();
                }

                public bool IsSetUnderlyingOptAttribute()
                {
                    return IsSetField(Tags.UnderlyingOptAttribute);
                }

                public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingContractMultiplier val)
                {
                    this.UnderlyingContractMultiplier = val;
                }

                public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val)
                {
                    return IsSetUnderlyingContractMultiplier();
                }

                public bool IsSetUnderlyingContractMultiplier()
                {
                    return IsSetField(Tags.UnderlyingContractMultiplier);
                }

                public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCouponRate val)
                {
                    this.UnderlyingCouponRate = val;
                }

                public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val)
                {
                    return IsSetUnderlyingCouponRate();
                }

                public bool IsSetUnderlyingCouponRate()
                {
                    return IsSetField(Tags.UnderlyingCouponRate);
                }

                public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityExchange val)
                {
                    this.UnderlyingSecurityExchange = val;
                }

                public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val)
                {
                    return IsSetUnderlyingSecurityExchange();
                }

                public bool IsSetUnderlyingSecurityExchange()
                {
                    return IsSetField(Tags.UnderlyingSecurityExchange);
                }

                public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingIssuer val)
                {
                    this.UnderlyingIssuer = val;
                }

                public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingIssuer val)
                {
                    return IsSetUnderlyingIssuer();
                }

                public bool IsSetUnderlyingIssuer()
                {
                    return IsSetField(Tags.UnderlyingIssuer);
                }

                public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
                {
                    this.EncodedUnderlyingIssuerLen = val;
                }

                public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
                {
                    return IsSetEncodedUnderlyingIssuerLen();
                }

                public bool IsSetEncodedUnderlyingIssuerLen()
                {
                    return IsSetField(Tags.EncodedUnderlyingIssuerLen);
                }

                public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                {
                    get
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val)
                {
                    this.EncodedUnderlyingIssuer = val;
                }

                public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val)
                {
                    return IsSetEncodedUnderlyingIssuer();
                }

                public bool IsSetEncodedUnderlyingIssuer()
                {
                    return IsSetField(Tags.EncodedUnderlyingIssuer);
                }

                public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityDesc val)
                {
                    this.UnderlyingSecurityDesc = val;
                }

                public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val)
                {
                    return IsSetUnderlyingSecurityDesc();
                }

                public bool IsSetUnderlyingSecurityDesc()
                {
                    return IsSetField(Tags.UnderlyingSecurityDesc);
                }

                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                {
                    get
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
                {
                    this.EncodedUnderlyingSecurityDescLen = val;
                }

                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
                {
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }

                public bool IsSetEncodedUnderlyingSecurityDescLen()
                {
                    return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
                }

                public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                {
                    get
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
                {
                    this.EncodedUnderlyingSecurityDesc = val;
                }

                public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
                {
                    return IsSetEncodedUnderlyingSecurityDesc();
                }

                public bool IsSetEncodedUnderlyingSecurityDesc()
                {
                    return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
                }

                public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCPProgram val)
                {
                    this.UnderlyingCPProgram = val;
                }

                public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val)
                {
                    return IsSetUnderlyingCPProgram();
                }

                public bool IsSetUnderlyingCPProgram()
                {
                    return IsSetField(Tags.UnderlyingCPProgram);
                }

                public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCPRegType val)
                {
                    this.UnderlyingCPRegType = val;
                }

                public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val)
                {
                    return IsSetUnderlyingCPRegType();
                }

                public bool IsSetUnderlyingCPRegType()
                {
                    return IsSetField(Tags.UnderlyingCPRegType);
                }

                public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCurrency val)
                {
                    this.UnderlyingCurrency = val;
                }

                public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCurrency val)
                {
                    return IsSetUnderlyingCurrency();
                }

                public bool IsSetUnderlyingCurrency()
                {
                    return IsSetField(Tags.UnderlyingCurrency);
                }

                public QuickFix.Fields.UnderlyingQty UnderlyingQty
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingQty val)
                {
                    this.UnderlyingQty = val;
                }

                public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingQty val)
                {
                    return IsSetUnderlyingQty();
                }

                public bool IsSetUnderlyingQty()
                {
                    return IsSetField(Tags.UnderlyingQty);
                }

                public QuickFix.Fields.UnderlyingPx UnderlyingPx
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingPx val)
                {
                    this.UnderlyingPx = val;
                }

                public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingPx val)
                {
                    return IsSetUnderlyingPx();
                }

                public bool IsSetUnderlyingPx()
                {
                    return IsSetField(Tags.UnderlyingPx);
                }

                public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingDirtyPrice val)
                {
                    this.UnderlyingDirtyPrice = val;
                }

                public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val)
                {
                    return IsSetUnderlyingDirtyPrice();
                }

                public bool IsSetUnderlyingDirtyPrice()
                {
                    return IsSetField(Tags.UnderlyingDirtyPrice);
                }

                public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingEndPrice val)
                {
                    this.UnderlyingEndPrice = val;
                }

                public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val)
                {
                    return IsSetUnderlyingEndPrice();
                }

                public bool IsSetUnderlyingEndPrice()
                {
                    return IsSetField(Tags.UnderlyingEndPrice);
                }

                public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingStartValue val)
                {
                    this.UnderlyingStartValue = val;
                }

                public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingStartValue val)
                {
                    return IsSetUnderlyingStartValue();
                }

                public bool IsSetUnderlyingStartValue()
                {
                    return IsSetField(Tags.UnderlyingStartValue);
                }

                public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCurrentValue val)
                {
                    this.UnderlyingCurrentValue = val;
                }

                public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val)
                {
                    return IsSetUnderlyingCurrentValue();
                }

                public bool IsSetUnderlyingCurrentValue()
                {
                    return IsSetField(Tags.UnderlyingCurrentValue);
                }

                public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingEndValue val)
                {
                    this.UnderlyingEndValue = val;
                }

                public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingEndValue val)
                {
                    return IsSetUnderlyingEndValue();
                }

                public bool IsSetUnderlyingEndValue()
                {
                    return IsSetField(Tags.UnderlyingEndValue);
                }

                public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
                {
                    get
                    {
                        QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoUnderlyingStips val)
                {
                    this.NoUnderlyingStips = val;
                }

                public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoUnderlyingStips val)
                {
                    return IsSetNoUnderlyingStips();
                }

                public bool IsSetNoUnderlyingStips()
                {
                    return IsSetField(Tags.NoUnderlyingStips);
                }

                public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingAllocationPercent val)
                {
                    this.UnderlyingAllocationPercent = val;
                }

                public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val)
                {
                    return IsSetUnderlyingAllocationPercent();
                }

                public bool IsSetUnderlyingAllocationPercent()
                {
                    return IsSetField(Tags.UnderlyingAllocationPercent);
                }

                public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSettlementType val)
                {
                    this.UnderlyingSettlementType = val;
                }

                public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val)
                {
                    return IsSetUnderlyingSettlementType();
                }

                public bool IsSetUnderlyingSettlementType()
                {
                    return IsSetField(Tags.UnderlyingSettlementType);
                }

                public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCashAmount val)
                {
                    this.UnderlyingCashAmount = val;
                }

                public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val)
                {
                    return IsSetUnderlyingCashAmount();
                }

                public bool IsSetUnderlyingCashAmount()
                {
                    return IsSetField(Tags.UnderlyingCashAmount);
                }

                public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCashType val)
                {
                    this.UnderlyingCashType = val;
                }

                public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCashType val)
                {
                    return IsSetUnderlyingCashType();
                }

                public bool IsSetUnderlyingCashType()
                {
                    return IsSetField(Tags.UnderlyingCashType);
                }

                public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val)
                {
                    this.UnderlyingUnitOfMeasure = val;
                }

                public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val)
                {
                    return IsSetUnderlyingUnitOfMeasure();
                }

                public bool IsSetUnderlyingUnitOfMeasure()
                {
                    return IsSetField(Tags.UnderlyingUnitOfMeasure);
                }

                public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingTimeUnit val)
                {
                    this.UnderlyingTimeUnit = val;
                }

                public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val)
                {
                    return IsSetUnderlyingTimeUnit();
                }

                public bool IsSetUnderlyingTimeUnit()
                {
                    return IsSetField(Tags.UnderlyingTimeUnit);
                }

                public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingCapValue val)
                {
                    this.UnderlyingCapValue = val;
                }

                public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingCapValue val)
                {
                    return IsSetUnderlyingCapValue();
                }

                public bool IsSetUnderlyingCapValue()
                {
                    return IsSetField(Tags.UnderlyingCapValue);
                }

                public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
                {
                    get
                    {
                        QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoUndlyInstrumentParties val)
                {
                    this.NoUndlyInstrumentParties = val;
                }

                public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val)
                {
                    return IsSetNoUndlyInstrumentParties();
                }

                public bool IsSetNoUndlyInstrumentParties()
                {
                    return IsSetField(Tags.NoUndlyInstrumentParties);
                }

                public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSettlMethod val)
                {
                    this.UnderlyingSettlMethod = val;
                }

                public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val)
                {
                    return IsSetUnderlyingSettlMethod();
                }

                public bool IsSetUnderlyingSettlMethod()
                {
                    return IsSetField(Tags.UnderlyingSettlMethod);
                }

                public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val)
                {
                    this.UnderlyingAdjustedQuantity = val;
                }

                public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val)
                {
                    return IsSetUnderlyingAdjustedQuantity();
                }

                public bool IsSetUnderlyingAdjustedQuantity()
                {
                    return IsSetField(Tags.UnderlyingAdjustedQuantity);
                }

                public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingFXRate val)
                {
                    this.UnderlyingFXRate = val;
                }

                public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingFXRate val)
                {
                    return IsSetUnderlyingFXRate();
                }

                public bool IsSetUnderlyingFXRate()
                {
                    return IsSetField(Tags.UnderlyingFXRate);
                }

                public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingFXRateCalc val)
                {
                    this.UnderlyingFXRateCalc = val;
                }

                public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val)
                {
                    return IsSetUnderlyingFXRateCalc();
                }

                public bool IsSetUnderlyingFXRateCalc()
                {
                    return IsSetField(Tags.UnderlyingFXRateCalc);
                }

                public QuickFix.Fields.CollAction CollAction
                {
                    get
                    {
                        QuickFix.Fields.CollAction val = new QuickFix.Fields.CollAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CollAction val)
                {
                    this.CollAction = val;
                }

                public QuickFix.Fields.CollAction Get(QuickFix.Fields.CollAction val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CollAction val)
                {
                    return IsSetCollAction();
                }

                public bool IsSetCollAction()
                {
                    return IsSetField(Tags.CollAction);
                }

                public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

                    public NoUnderlyingSecurityAltIDGroup()
                      : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    {
                        get
                        {
                            QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UnderlyingSecurityAltID val)
                    {
                        this.UnderlyingSecurityAltID = val;
                    }

                    public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val)
                    {
                        return IsSetUnderlyingSecurityAltID();
                    }

                    public bool IsSetUnderlyingSecurityAltID()
                    {
                        return IsSetField(Tags.UnderlyingSecurityAltID);
                    }

                    public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    {
                        get
                        {
                            QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                    {
                        this.UnderlyingSecurityAltIDSource = val;
                    }

                    public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                    {
                        return IsSetUnderlyingSecurityAltIDSource();
                    }

                    public bool IsSetUnderlyingSecurityAltIDSource()
                    {
                        return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                    }


                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

                    public NoUnderlyingStipsGroup()
                      : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
                    {
                        get
                        {
                            QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UnderlyingStipType val)
                    {
                        this.UnderlyingStipType = val;
                    }

                    public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UnderlyingStipType val)
                    {
                        return IsSetUnderlyingStipType();
                    }

                    public bool IsSetUnderlyingStipType()
                    {
                        return IsSetField(Tags.UnderlyingStipType);
                    }

                    public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
                    {
                        get
                        {
                            QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UnderlyingStipValue val)
                    {
                        this.UnderlyingStipValue = val;
                    }

                    public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UnderlyingStipValue val)
                    {
                        return IsSetUnderlyingStipValue();
                    }

                    public bool IsSetUnderlyingStipValue()
                    {
                        return IsSetField(Tags.UnderlyingStipValue);
                    }


                }
                public class NoUndlyInstrumentPartiesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

                    public NoUndlyInstrumentPartiesGroup()
                      : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoUndlyInstrumentPartiesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyID UndlyInstrumentPartyID
                    {
                        get
                        {
                            QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UndlyInstrumentPartyID val)
                    {
                        this.UndlyInstrumentPartyID = val;
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val)
                    {
                        return IsSetUndlyInstrumentPartyID();
                    }

                    public bool IsSetUndlyInstrumentPartyID()
                    {
                        return IsSetField(Tags.UndlyInstrumentPartyID);
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
                    {
                        get
                        {
                            QuickFix.Fields.UndlyInstrumentPartyIDSource val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
                    {
                        this.UndlyInstrumentPartyIDSource = val;
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
                    {
                        return IsSetUndlyInstrumentPartyIDSource();
                    }

                    public bool IsSetUndlyInstrumentPartyIDSource()
                    {
                        return IsSetField(Tags.UndlyInstrumentPartyIDSource);
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
                    {
                        get
                        {
                            QuickFix.Fields.UndlyInstrumentPartyRole val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val)
                    {
                        this.UndlyInstrumentPartyRole = val;
                    }

                    public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val)
                    {
                        return IsSetUndlyInstrumentPartyRole();
                    }

                    public bool IsSetUndlyInstrumentPartyRole()
                    {
                        return IsSetField(Tags.UndlyInstrumentPartyRole);
                    }

                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
                    {
                        get
                        {
                            QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val)
                    {
                        this.NoUndlyInstrumentPartySubIDs = val;
                    }

                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val)
                    {
                        return IsSetNoUndlyInstrumentPartySubIDs();
                    }

                    public bool IsSetNoUndlyInstrumentPartySubIDs()
                    {
                        return IsSetField(Tags.NoUndlyInstrumentPartySubIDs);
                    }

                    public class NoUndlyInstrumentPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

                        public NoUndlyInstrumentPartySubIDsGroup()
                          : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoUndlyInstrumentPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.UndlyInstrumentPartySubID UndlyInstrumentPartySubID
                        {
                            get
                            {
                                QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val)
                        {
                            this.UndlyInstrumentPartySubID = val;
                        }

                        public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val)
                        {
                            return IsSetUndlyInstrumentPartySubID();
                        }

                        public bool IsSetUndlyInstrumentPartySubID()
                        {
                            return IsSetField(Tags.UndlyInstrumentPartySubID);
                        }

                        public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
                        {
                            get
                            {
                                QuickFix.Fields.UndlyInstrumentPartySubIDType val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
                        {
                            this.UndlyInstrumentPartySubIDType = val;
                        }

                        public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
                        {
                            return IsSetUndlyInstrumentPartySubIDType();
                        }

                        public bool IsSetUndlyInstrumentPartySubIDType()
                        {
                            return IsSetField(Tags.UndlyInstrumentPartySubIDType);
                        }


                    }
                }
            }
            public class NoTrdRegTimestampsGroup : Group
            {
                public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};

                public NoTrdRegTimestampsGroup()
                  : base(Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTrdRegTimestampsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.TrdRegTimestamp TrdRegTimestamp
                {
                    get
                    {
                        QuickFix.Fields.TrdRegTimestamp val = new QuickFix.Fields.TrdRegTimestamp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TrdRegTimestamp val)
                {
                    this.TrdRegTimestamp = val;
                }

                public QuickFix.Fields.TrdRegTimestamp Get(QuickFix.Fields.TrdRegTimestamp val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TrdRegTimestamp val)
                {
                    return IsSetTrdRegTimestamp();
                }

                public bool IsSetTrdRegTimestamp()
                {
                    return IsSetField(Tags.TrdRegTimestamp);
                }

                public QuickFix.Fields.TrdRegTimestampType TrdRegTimestampType
                {
                    get
                    {
                        QuickFix.Fields.TrdRegTimestampType val = new QuickFix.Fields.TrdRegTimestampType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TrdRegTimestampType val)
                {
                    this.TrdRegTimestampType = val;
                }

                public QuickFix.Fields.TrdRegTimestampType Get(QuickFix.Fields.TrdRegTimestampType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TrdRegTimestampType val)
                {
                    return IsSetTrdRegTimestampType();
                }

                public bool IsSetTrdRegTimestampType()
                {
                    return IsSetField(Tags.TrdRegTimestampType);
                }

                public QuickFix.Fields.TrdRegTimestampOrigin TrdRegTimestampOrigin
                {
                    get
                    {
                        QuickFix.Fields.TrdRegTimestampOrigin val = new QuickFix.Fields.TrdRegTimestampOrigin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.TrdRegTimestampOrigin val)
                {
                    this.TrdRegTimestampOrigin = val;
                }

                public QuickFix.Fields.TrdRegTimestampOrigin Get(QuickFix.Fields.TrdRegTimestampOrigin val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.TrdRegTimestampOrigin val)
                {
                    return IsSetTrdRegTimestampOrigin();
                }

                public bool IsSetTrdRegTimestampOrigin()
                {
                    return IsSetField(Tags.TrdRegTimestampOrigin);
                }

                public QuickFix.Fields.DeskType DeskType
                {
                    get
                    {
                        QuickFix.Fields.DeskType val = new QuickFix.Fields.DeskType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DeskType val)
                {
                    this.DeskType = val;
                }

                public QuickFix.Fields.DeskType Get(QuickFix.Fields.DeskType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DeskType val)
                {
                    return IsSetDeskType();
                }

                public bool IsSetDeskType()
                {
                    return IsSetField(Tags.DeskType);
                }

                public QuickFix.Fields.DeskTypeSource DeskTypeSource
                {
                    get
                    {
                        QuickFix.Fields.DeskTypeSource val = new QuickFix.Fields.DeskTypeSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DeskTypeSource val)
                {
                    this.DeskTypeSource = val;
                }

                public QuickFix.Fields.DeskTypeSource Get(QuickFix.Fields.DeskTypeSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DeskTypeSource val)
                {
                    return IsSetDeskTypeSource();
                }

                public bool IsSetDeskTypeSource()
                {
                    return IsSetField(Tags.DeskTypeSource);
                }

                public QuickFix.Fields.DeskOrderHandlingInst DeskOrderHandlingInst
                {
                    get
                    {
                        QuickFix.Fields.DeskOrderHandlingInst val = new QuickFix.Fields.DeskOrderHandlingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DeskOrderHandlingInst val)
                {
                    this.DeskOrderHandlingInst = val;
                }

                public QuickFix.Fields.DeskOrderHandlingInst Get(QuickFix.Fields.DeskOrderHandlingInst val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DeskOrderHandlingInst val)
                {
                    return IsSetDeskOrderHandlingInst();
                }

                public bool IsSetDeskOrderHandlingInst()
                {
                    return IsSetField(Tags.DeskOrderHandlingInst);
                }


            }
            public class NoMiscFeesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

                public NoMiscFeesGroup()
                  : base(Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMiscFeesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeAmt val = new QuickFix.Fields.MiscFeeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeAmt val)
                {
                    this.MiscFeeAmt = val;
                }

                public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeAmt val)
                {
                    return IsSetMiscFeeAmt();
                }

                public bool IsSetMiscFeeAmt()
                {
                    return IsSetField(Tags.MiscFeeAmt);
                }

                public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeCurr val = new QuickFix.Fields.MiscFeeCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeCurr val)
                {
                    this.MiscFeeCurr = val;
                }

                public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeCurr val)
                {
                    return IsSetMiscFeeCurr();
                }

                public bool IsSetMiscFeeCurr()
                {
                    return IsSetField(Tags.MiscFeeCurr);
                }

                public QuickFix.Fields.MiscFeeType MiscFeeType
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeType val = new QuickFix.Fields.MiscFeeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeType val)
                {
                    this.MiscFeeType = val;
                }

                public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeType val)
                {
                    return IsSetMiscFeeType();
                }

                public bool IsSetMiscFeeType()
                {
                    return IsSetField(Tags.MiscFeeType);
                }

                public QuickFix.Fields.MiscFeeBasis MiscFeeBasis
                {
                    get
                    {
                        QuickFix.Fields.MiscFeeBasis val = new QuickFix.Fields.MiscFeeBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MiscFeeBasis val)
                {
                    this.MiscFeeBasis = val;
                }

                public QuickFix.Fields.MiscFeeBasis Get(QuickFix.Fields.MiscFeeBasis val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MiscFeeBasis val)
                {
                    return IsSetMiscFeeBasis();
                }

                public bool IsSetMiscFeeBasis()
                {
                    return IsSetField(Tags.MiscFeeBasis);
                }


            }
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

                public NoStipulationsGroup()
                  : base(Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.StipulationType StipulationType
                {
                    get
                    {
                        QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StipulationType val)
                {
                    this.StipulationType = val;
                }

                public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StipulationType val)
                {
                    return IsSetStipulationType();
                }

                public bool IsSetStipulationType()
                {
                    return IsSetField(Tags.StipulationType);
                }

                public QuickFix.Fields.StipulationValue StipulationValue
                {
                    get
                    {
                        QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.StipulationValue val)
                {
                    this.StipulationValue = val;
                }

                public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.StipulationValue val)
                {
                    return IsSetStipulationValue();
                }

                public bool IsSetStipulationValue()
                {
                    return IsSetField(Tags.StipulationValue);
                }


            }
            public class NoDlvyInstGroup : Group
            {
                public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};

                public NoDlvyInstGroup()
                  : base(Tags.NoDlvyInst, Tags.SettlInstSource, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoDlvyInstGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.SettlInstSource SettlInstSource
                {
                    get
                    {
                        QuickFix.Fields.SettlInstSource val = new QuickFix.Fields.SettlInstSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlInstSource val)
                {
                    this.SettlInstSource = val;
                }

                public QuickFix.Fields.SettlInstSource Get(QuickFix.Fields.SettlInstSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlInstSource val)
                {
                    return IsSetSettlInstSource();
                }

                public bool IsSetSettlInstSource()
                {
                    return IsSetField(Tags.SettlInstSource);
                }

                public QuickFix.Fields.DlvyInstType DlvyInstType
                {
                    get
                    {
                        QuickFix.Fields.DlvyInstType val = new QuickFix.Fields.DlvyInstType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.DlvyInstType val)
                {
                    this.DlvyInstType = val;
                }

                public QuickFix.Fields.DlvyInstType Get(QuickFix.Fields.DlvyInstType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.DlvyInstType val)
                {
                    return IsSetDlvyInstType();
                }

                public bool IsSetDlvyInstType()
                {
                    return IsSetField(Tags.DlvyInstType);
                }

                public QuickFix.Fields.NoSettlPartyIDs NoSettlPartyIDs
                {
                    get
                    {
                        QuickFix.Fields.NoSettlPartyIDs val = new QuickFix.Fields.NoSettlPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoSettlPartyIDs val)
                {
                    this.NoSettlPartyIDs = val;
                }

                public QuickFix.Fields.NoSettlPartyIDs Get(QuickFix.Fields.NoSettlPartyIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoSettlPartyIDs val)
                {
                    return IsSetNoSettlPartyIDs();
                }

                public bool IsSetNoSettlPartyIDs()
                {
                    return IsSetField(Tags.NoSettlPartyIDs);
                }

                public class NoSettlPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

                    public NoSettlPartyIDsGroup()
                      : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoSettlPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.SettlPartyID SettlPartyID
                    {
                        get
                        {
                            QuickFix.Fields.SettlPartyID val = new QuickFix.Fields.SettlPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.SettlPartyID val)
                    {
                        this.SettlPartyID = val;
                    }

                    public QuickFix.Fields.SettlPartyID Get(QuickFix.Fields.SettlPartyID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.SettlPartyID val)
                    {
                        return IsSetSettlPartyID();
                    }

                    public bool IsSetSettlPartyID()
                    {
                        return IsSetField(Tags.SettlPartyID);
                    }

                    public QuickFix.Fields.SettlPartyIDSource SettlPartyIDSource
                    {
                        get
                        {
                            QuickFix.Fields.SettlPartyIDSource val = new QuickFix.Fields.SettlPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.SettlPartyIDSource val)
                    {
                        this.SettlPartyIDSource = val;
                    }

                    public QuickFix.Fields.SettlPartyIDSource Get(QuickFix.Fields.SettlPartyIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.SettlPartyIDSource val)
                    {
                        return IsSetSettlPartyIDSource();
                    }

                    public bool IsSetSettlPartyIDSource()
                    {
                        return IsSetField(Tags.SettlPartyIDSource);
                    }

                    public QuickFix.Fields.SettlPartyRole SettlPartyRole
                    {
                        get
                        {
                            QuickFix.Fields.SettlPartyRole val = new QuickFix.Fields.SettlPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.SettlPartyRole val)
                    {
                        this.SettlPartyRole = val;
                    }

                    public QuickFix.Fields.SettlPartyRole Get(QuickFix.Fields.SettlPartyRole val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.SettlPartyRole val)
                    {
                        return IsSetSettlPartyRole();
                    }

                    public bool IsSetSettlPartyRole()
                    {
                        return IsSetField(Tags.SettlPartyRole);
                    }

                    public QuickFix.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
                    {
                        get
                        {
                            QuickFix.Fields.NoSettlPartySubIDs val = new QuickFix.Fields.NoSettlPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoSettlPartySubIDs val)
                    {
                        this.NoSettlPartySubIDs = val;
                    }

                    public QuickFix.Fields.NoSettlPartySubIDs Get(QuickFix.Fields.NoSettlPartySubIDs val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoSettlPartySubIDs val)
                    {
                        return IsSetNoSettlPartySubIDs();
                    }

                    public bool IsSetNoSettlPartySubIDs()
                    {
                        return IsSetField(Tags.NoSettlPartySubIDs);
                    }

                    public class NoSettlPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

                        public NoSettlPartySubIDsGroup()
                          : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoSettlPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.SettlPartySubID SettlPartySubID
                        {
                            get
                            {
                                QuickFix.Fields.SettlPartySubID val = new QuickFix.Fields.SettlPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.SettlPartySubID val)
                        {
                            this.SettlPartySubID = val;
                        }

                        public QuickFix.Fields.SettlPartySubID Get(QuickFix.Fields.SettlPartySubID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.SettlPartySubID val)
                        {
                            return IsSetSettlPartySubID();
                        }

                        public bool IsSetSettlPartySubID()
                        {
                            return IsSetField(Tags.SettlPartySubID);
                        }

                        public QuickFix.Fields.SettlPartySubIDType SettlPartySubIDType
                        {
                            get
                            {
                                QuickFix.Fields.SettlPartySubIDType val = new QuickFix.Fields.SettlPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.SettlPartySubIDType val)
                        {
                            this.SettlPartySubIDType = val;
                        }

                        public QuickFix.Fields.SettlPartySubIDType Get(QuickFix.Fields.SettlPartySubIDType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.SettlPartySubIDType val)
                        {
                            return IsSetSettlPartySubIDType();
                        }

                        public bool IsSetSettlPartySubIDType()
                        {
                            return IsSetField(Tags.SettlPartySubIDType);
                        }


                    }
                }
            }
        }
    }
}
