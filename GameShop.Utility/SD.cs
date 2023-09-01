using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Utility
{
	public static class SD
	{
		public const string Role_Customer = "お客様";
		public const string Role_Company = "企業";
		public const string Role_Admin = "管理者";
		public const string Role_Employee = "従業員";

		public const string StatusPending = "保留中";
		public const string StatusApproved = "承認";
		public const string StatusInProcess = "手続中";
		public const string StatusShipped = "発送済";
		public const string StatusCancelled = "キャンセル";
		public const string StatusRefunded = "返金";

		public const string PaymentStatusPending = "保留中";
		public const string PaymentStatusApproved = "承認";
		public const string PaymentStatusDelayedPayment = "支払い遅延が承認";
		public const string PaymentStatusRejected = "拒否";
	}
}
