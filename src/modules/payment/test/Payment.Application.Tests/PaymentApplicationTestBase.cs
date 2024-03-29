﻿using Volo.Abp.Modularity;

namespace Payment;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class PaymentApplicationTestBase<TStartupModule> : PaymentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
