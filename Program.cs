namespace DeathSwitch;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => Results.Content(Page, "text/html"));

        app.Run();
    }

    private const string Page = """
<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Standard Bank DeathSwitch Mobile Prototype</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css" rel="stylesheet">
    <style>
        :root {
            --bs-primary: #0033a1;
            --bs-primary-rgb: 0, 51, 161;
            --sb-dark: #061b5f;
            --sb-screen: #f3f6fb;
        }

        body {
            min-height: 100vh;
            background:
                radial-gradient(circle at top left, rgba(0, 51, 161, .16), transparent 32rem),
                linear-gradient(135deg, #eef3fb, #dfe8f5);
            font-family: "Segoe UI", system-ui, -apple-system, BlinkMacSystemFont, sans-serif;
            letter-spacing: 0;
        }

        .desktop-stage {
            min-height: 100vh;
        }

        .phone-frame {
            width: min(100%, 430px);
            height: min(932px, calc(100vh - 32px));
            min-height: 720px;
            border: 12px solid #111827;
            border-radius: 42px;
            background: var(--sb-screen);
            overflow: hidden;
            box-shadow: 0 28px 80px rgba(15, 23, 42, .28);
            position: relative;
        }

        .phone-notch {
            width: 128px;
            height: 28px;
            background: #111827;
            border-radius: 0 0 18px 18px;
            position: absolute;
            top: 0;
            left: 50%;
            transform: translateX(-50%);
            z-index: 4;
        }

        .phone-screen {
            height: 100%;
            overflow-y: auto;
            padding-bottom: 88px;
        }

        .app-header {
            background: linear-gradient(160deg, var(--bs-primary), var(--sb-dark));
            color: #fff;
            border-radius: 0 0 28px 28px;
            padding: 26px 18px 24px;
        }

        .brand-tile {
            width: 38px;
            height: 38px;
            border-radius: 10px;
            color: var(--bs-primary);
        }

        .balance-card {
            background: rgba(255, 255, 255, .13);
            border: 1px solid rgba(255, 255, 255, .2);
            color: #fff;
        }

        .quick-action {
            min-height: 76px;
        }

        .quick-action i {
            font-size: 1.25rem;
        }

        .content-stack {
            padding: 16px;
        }

        .nav-pills .nav-link {
            color: #4b5563;
            font-weight: 700;
            white-space: nowrap;
        }

        .nav-pills .nav-link.active {
            background: var(--bs-primary);
        }

        .bottom-nav {
            position: absolute;
            left: 0;
            right: 0;
            bottom: 0;
            background: #fff;
            border-top: 1px solid #dde5f2;
            z-index: 3;
        }

        .bottom-nav .nav-link {
            color: #667085;
            font-size: .72rem;
            font-weight: 700;
            padding: 10px 4px;
        }

        .bottom-nav .nav-link.active {
            color: var(--bs-primary);
        }

        .bottom-nav i {
            display: block;
            font-size: 1.2rem;
            line-height: 1.1;
        }

        .card,
        .btn,
        .form-control,
        .form-select,
        .list-group,
        .accordion-item {
            border-radius: 14px;
        }

        .avatar-icon {
            width: 42px;
            height: 42px;
        }

        .small-table td,
        .small-table th {
            font-size: .82rem;
        }

        @media (max-width: 575.98px) {
            body {
                background: var(--sb-screen);
            }

            .desktop-stage {
                min-height: 100vh;
                padding: 0 !important;
            }

            .phone-frame {
                width: 100%;
                height: 100vh;
                min-height: 100vh;
                border: 0;
                border-radius: 0;
                box-shadow: none;
            }

            .phone-notch {
                display: none;
            }
        }
    </style>
</head>
<body>
    <main class="desktop-stage d-flex align-items-center justify-content-center p-3">
        <div class="phone-frame">
            <div class="phone-notch"></div>
            <div class="phone-screen">
                <header class="app-header">
                    <div class="d-flex align-items-center justify-content-between mb-4">
                        <div class="d-flex align-items-center gap-2">
                            <div class="brand-tile bg-white d-flex align-items-center justify-content-center fw-bold">SB</div>
                            <div>
                                <div class="fw-bold">Standard Bank</div>
                                <small class="text-white-50">Estate Care</small>
                            </div>
                        </div>
                        <button class="btn btn-sm btn-light rounded-circle" type="button" aria-label="Notifications">
                            <i class="bi bi-bell"></i>
                        </button>
                    </div>

                    <div class="card balance-card shadow-sm">
                        <div class="card-body">
                            <div class="d-flex justify-content-between align-items-start mb-3">
                                <div>
                                    <small class="text-white-50">Protected balance</small>
                                    <div class="h2 fw-bold mb-0">R 128,400</div>
                                </div>
                                <span class="badge text-bg-success">Active</span>
                            </div>
                            <div class="row g-2">
                                <div class="col-6">
                                    <div class="small text-white-50">Emergency release</div>
                                    <div class="fw-bold">R 5,000</div>
                                </div>
                                <div class="col-6">
                                    <div class="small text-white-50">Death score</div>
                                    <div class="fw-bold">0%</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </header>

                <div class="content-stack">
                    <section class="row g-2 mb-3">
                        <div class="col-4">
                            <button class="btn btn-light border w-100 quick-action shadow-sm" type="button">
                                <i class="bi bi-person-plus text-primary"></i>
                                <span class="d-block small fw-bold mt-1">Add</span>
                            </button>
                        </div>
                        <div class="col-4">
                            <button class="btn btn-light border w-100 quick-action shadow-sm" type="button">
                                <i class="bi bi-camera-video text-primary"></i>
                                <span class="d-block small fw-bold mt-1">Message</span>
                            </button>
                        </div>
                        <div class="col-4">
                            <button class="btn btn-light border w-100 quick-action shadow-sm" type="button">
                                <i class="bi bi-shield-check text-primary"></i>
                                <span class="d-block small fw-bold mt-1">Verify</span>
                            </button>
                        </div>
                    </section>

                    <ul class="nav nav-pills flex-nowrap overflow-auto bg-white border p-1 mb-3 shadow-sm" id="estateTabs" role="tablist">
                        <li class="nav-item" role="presentation">
                            <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home-tab-pane" type="button" role="tab">Home</button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="people-tab" data-bs-toggle="tab" data-bs-target="#people-tab-pane" type="button" role="tab">People</button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="signals-tab" data-bs-toggle="tab" data-bs-target="#signals-tab-pane" type="button" role="tab">Signals</button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="rules-tab" data-bs-toggle="tab" data-bs-target="#rules-tab-pane" type="button" role="tab">Rules</button>
                        </li>
                    </ul>

                    <div class="tab-content">
                        <section class="tab-pane fade show active" id="home-tab-pane" role="tabpanel" tabindex="0">
                            <div class="alert alert-primary shadow-sm" role="alert">
                                <div class="fw-bold"><i class="bi bi-info-circle me-1"></i> Family access is ready</div>
                                Emergency funds will only release after converging evidence and a 24 hour cooling period.
                            </div>

                            <div class="card shadow-sm mb-3">
                                <div class="card-header bg-white d-flex justify-content-between align-items-center">
                                    <h2 class="h6 fw-bold mb-0">Today</h2>
                                    <span class="badge text-bg-success">No risk</span>
                                </div>
                                <div class="list-group list-group-flush">
                                    <div class="list-group-item d-flex justify-content-between align-items-center">
                                        <div>
                                            <div class="fw-bold">Liveness ping</div>
                                            <small class="text-secondary">Last answered 12 May</small>
                                        </div>
                                        <i class="bi bi-check-circle-fill text-success"></i>
                                    </div>
                                    <div class="list-group-item d-flex justify-content-between align-items-center">
                                        <div>
                                            <div class="fw-bold">SIM swap check</div>
                                            <small class="text-secondary">No recent SIM swap detected</small>
                                        </div>
                                        <i class="bi bi-check-circle-fill text-success"></i>
                                    </div>
                                </div>
                            </div>

                            <div class="card shadow-sm mb-3">
                                <div class="card-body">
                                    <div class="d-flex justify-content-between align-items-center mb-2">
                                        <h2 class="h6 fw-bold mb-0">Activation progress</h2>
                                        <span class="badge text-bg-primary">0%</span>
                                    </div>
                                    <div class="progress mb-2" role="progressbar" aria-label="Death probability" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100">
                                        <div class="progress-bar" style="width: 0%"></div>
                                    </div>
                                    <small class="text-secondary">No single signal can activate payouts alone.</small>
                                </div>
                            </div>

                            <div class="card shadow-sm">
                                <div class="card-header bg-white">
                                    <h2 class="h6 fw-bold mb-0">Beneficiary claim journey</h2>
                                </div>
                                <div class="accordion accordion-flush" id="claimJourney">
                                    <div class="accordion-item">
                                        <h3 class="accordion-header">
                                            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#claimOne">
                                                <i class="bi bi-whatsapp me-2 text-success"></i> WhatsApp alert
                                            </button>
                                        </h3>
                                        <div id="claimOne" class="accordion-collapse collapse show" data-bs-parent="#claimJourney">
                                            <div class="accordion-body text-secondary">All beneficiaries are notified from a verified Standard Bank sender.</div>
                                        </div>
                                    </div>
                                    <div class="accordion-item">
                                        <h3 class="accordion-header">
                                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#claimTwo">
                                                <i class="bi bi-camera me-2 text-primary"></i> Selfie and ID
                                            </button>
                                        </h3>
                                        <div id="claimTwo" class="accordion-collapse collapse" data-bs-parent="#claimJourney">
                                            <div class="accordion-body text-secondary">The recipient verifies identity before money is released.</div>
                                        </div>
                                    </div>
                                    <div class="accordion-item">
                                        <h3 class="accordion-header">
                                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#claimThree">
                                                <i class="bi bi-bank me-2 text-primary"></i> Bank payout
                                            </button>
                                        </h3>
                                        <div id="claimThree" class="accordion-collapse collapse" data-bs-parent="#claimJourney">
                                            <div class="accordion-body text-secondary">Funds land in a verified bank account registered to that beneficiary.</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>

                        <section class="tab-pane fade" id="people-tab-pane" role="tabpanel" tabindex="0">
                            <div class="card shadow-sm mb-3">
                                <div class="card-header bg-white d-flex justify-content-between align-items-center">
                                    <h2 class="h6 fw-bold mb-0">Beneficiaries</h2>
                                    <button class="btn btn-sm btn-primary" type="button"><i class="bi bi-plus-lg"></i></button>
                                </div>
                                <div class="list-group list-group-flush">
                                    <div class="list-group-item">
                                        <div class="d-flex gap-3 align-items-center">
                                            <div class="avatar-icon rounded-circle bg-primary-subtle text-primary d-flex align-items-center justify-content-center"><i class="bi bi-person-check"></i></div>
                                            <div class="flex-grow-1">
                                                <div class="d-flex justify-content-between">
                                                    <strong>Naledi Mokoena</strong>
                                                    <span class="badge text-bg-primary">55%</span>
                                                </div>
                                                <small class="text-secondary">Spouse | Standard Bank **** 1842</small>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="list-group-item">
                                        <div class="d-flex gap-3 align-items-center">
                                            <div class="avatar-icon rounded-circle bg-primary-subtle text-primary d-flex align-items-center justify-content-center"><i class="bi bi-person-check"></i></div>
                                            <div class="flex-grow-1">
                                                <div class="d-flex justify-content-between">
                                                    <strong>Lerato Mokoena</strong>
                                                    <span class="badge text-bg-info">25%</span>
                                                </div>
                                                <small class="text-secondary">Daughter | Standard Bank **** 7731</small>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="list-group-item">
                                        <div class="d-flex gap-3 align-items-center">
                                            <div class="avatar-icon rounded-circle bg-primary-subtle text-primary d-flex align-items-center justify-content-center"><i class="bi bi-person-check"></i></div>
                                            <div class="flex-grow-1">
                                                <div class="d-flex justify-content-between">
                                                    <strong>Kabelo Mokoena</strong>
                                                    <span class="badge text-bg-info">15%</span>
                                                </div>
                                                <small class="text-secondary">Son | Standard Bank **** 6025</small>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="list-group-item">
                                        <div class="d-flex gap-3 align-items-center">
                                            <div class="avatar-icon rounded-circle bg-warning-subtle text-warning d-flex align-items-center justify-content-center"><i class="bi bi-exclamation-triangle"></i></div>
                                            <div class="flex-grow-1">
                                                <div class="d-flex justify-content-between">
                                                    <strong>Grace Mokoena</strong>
                                                    <span class="badge text-bg-warning">Review</span>
                                                </div>
                                                <small class="text-secondary">Mother | changed within 90 days</small>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="card shadow-sm">
                                <div class="card-header bg-white">
                                    <h2 class="h6 fw-bold mb-0">Add beneficiary</h2>
                                </div>
                                <div class="card-body">
                                    <form class="row g-3">
                                        <div class="col-12">
                                            <label class="form-label">Full name</label>
                                            <div class="input-group">
                                                <span class="input-group-text"><i class="bi bi-person"></i></span>
                                                <input class="form-control" value="Amo Mokoena">
                                            </div>
                                        </div>
                                        <div class="col-6">
                                            <label class="form-label">Relationship</label>
                                            <select class="form-select">
                                                <option>Spouse</option>
                                                <option>Child</option>
                                                <option>Parent</option>
                                                <option>Sibling</option>
                                            </select>
                                        </div>
                                        <div class="col-6">
                                            <label class="form-label">Amount</label>
                                            <div class="input-group">
                                                <span class="input-group-text">R</span>
                                                <input class="form-control" value="2,000">
                                            </div>
                                        </div>
                                        <div class="col-12">
                                            <label class="form-label">ID number</label>
                                            <input class="form-control" value="9001015800085">
                                        </div>
                                        <div class="col-12 d-grid">
                                            <button class="btn btn-primary" type="button">Save and verify</button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </section>

                        <section class="tab-pane fade" id="signals-tab-pane" role="tabpanel" tabindex="0">
                            <div class="card shadow-sm mb-3">
                                <div class="card-body text-center">
                                    <span class="badge text-bg-success mb-2">Live monitoring</span>
                                    <div class="display-3 fw-bold text-primary">0%</div>
                                    <div class="text-secondary">death probability score</div>
                                </div>
                            </div>

                            <div class="list-group shadow-sm mb-3">
                                <div class="list-group-item d-flex justify-content-between align-items-start">
                                    <div>
                                        <strong><i class="bi bi-hospital text-primary me-2"></i>Hospital discharge</strong>
                                        <div class="small text-secondary">No deceased discharge received</div>
                                    </div>
                                    <span class="badge text-bg-primary rounded-pill">40%</span>
                                </div>
                                <div class="list-group-item d-flex justify-content-between align-items-start">
                                    <div>
                                        <strong><i class="bi bi-file-medical text-primary me-2"></i>BI-1663</strong>
                                        <div class="small text-secondary">Practitioner portal ready</div>
                                    </div>
                                    <span class="badge text-bg-primary rounded-pill">30%</span>
                                </div>
                                <div class="list-group-item d-flex justify-content-between align-items-start">
                                    <div>
                                        <strong><i class="bi bi-person-vcard text-primary me-2"></i>Next of kin</strong>
                                        <div class="small text-secondary">WhatsApp upload enabled</div>
                                    </div>
                                    <span class="badge text-bg-primary rounded-pill">15%</span>
                                </div>
                                <div class="list-group-item d-flex justify-content-between align-items-start">
                                    <div>
                                        <strong><i class="bi bi-chat-dots text-primary me-2"></i>Liveness ping</strong>
                                        <div class="small text-secondary">Next ping scheduled 11 June</div>
                                    </div>
                                    <span class="badge text-bg-primary rounded-pill">10%</span>
                                </div>
                                <div class="list-group-item d-flex justify-content-between align-items-start">
                                    <div>
                                        <strong><i class="bi bi-phone text-primary me-2"></i>Network presence</strong>
                                        <div class="small text-secondary">SIM swap clear</div>
                                    </div>
                                    <span class="badge text-bg-primary rounded-pill">5%</span>
                                </div>
                            </div>
                        </section>

                        <section class="tab-pane fade" id="rules-tab-pane" role="tabpanel" tabindex="0">
                            <div class="card shadow-sm mb-3">
                                <div class="card-header bg-white">
                                    <h2 class="h6 fw-bold mb-0">Release rules</h2>
                                </div>
                                <div class="table-responsive">
                                    <table class="table small-table align-middle mb-0">
                                        <thead class="table-light">
                                            <tr>
                                                <th>Score</th>
                                                <th>Action</th>
                                                <th>Status</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>40%</td>
                                                <td>Notify family and soft freeze above R500</td>
                                                <td><span class="badge text-bg-success">On</span></td>
                                            </tr>
                                            <tr>
                                                <td>70%</td>
                                                <td>Release R5,000 after 24 hours</td>
                                                <td><span class="badge text-bg-success">On</span></td>
                                            </tr>
                                            <tr>
                                                <td>85%</td>
                                                <td>Request death certificate</td>
                                                <td><span class="badge text-bg-success">On</span></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>

                            <div class="card shadow-sm">
                                <div class="card-header bg-white">
                                    <h2 class="h6 fw-bold mb-0">Fraud controls</h2>
                                </div>
                                <div class="list-group list-group-flush">
                                    <div class="list-group-item d-flex justify-content-between">
                                        DHA certificate validation
                                        <span class="badge text-bg-success">Ready</span>
                                    </div>
                                    <div class="list-group-item d-flex justify-content-between">
                                        SIM swap risk check
                                        <span class="badge text-bg-success">Clear</span>
                                    </div>
                                    <div class="list-group-item d-flex justify-content-between">
                                        Beneficiary bank ownership
                                        <span class="badge text-bg-success">Matched</span>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </div>

            <nav class="bottom-nav">
                <ul class="nav nav-fill">
                    <li class="nav-item">
                        <a class="nav-link active" href="#"><i class="bi bi-house-door"></i>Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><i class="bi bi-credit-card"></i>Accounts</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><i class="bi bi-arrow-left-right"></i>Pay</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><i class="bi bi-person"></i>Profile</a>
                    </li>
                </ul>
            </nav>
        </div>
    </main>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
""";
}
